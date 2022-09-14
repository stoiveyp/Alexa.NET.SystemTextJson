using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.SystemTextJson
{
    public abstract class DiscriminatorJsonConverter<T> : JsonConverter<T>
    {
        protected DiscriminatorJsonConverter(string propertyName)
        {
            PropertyName = propertyName;
        }

        private T LoadFromDiscriminator(ref Utf8JsonReader reader, string propertyName, JsonSerializerOptions options)
        {
            var dReader = reader;
            if (dReader.TokenType != JsonTokenType.StartObject)
            {
                throw new InvalidOperationException("Bad position for a JSON object");
            }

            ScanObjectForType(ref dReader, propertyName);

            if (dReader.TokenType == JsonTokenType.EndObject)
            {
                throw new InvalidOperationException($"Unable to find {propertyName} discriminator");
            }

            dReader.Read();
            var discriminator = (dReader.TokenType == JsonTokenType.Number)
                ? dReader.GetInt32().ToString()
                : dReader.GetString();

            var newOptions = new JsonSerializerOptions(options);
            newOptions.Converters.Remove(this);
            return GenerateFromDiscriminator(discriminator, ref reader, newOptions);
        }

        private void ScanObjectForType(ref Utf8JsonReader dReader, string propertyName, bool skip = false)
        {
            while (skip || dReader.TokenType != JsonTokenType.PropertyName || dReader.GetString() != propertyName)
            {
                dReader.Read();
                if (dReader.TokenType == JsonTokenType.StartObject)
                {
                    ScanObjectForType(ref dReader, propertyName, true);
                }
                else if (dReader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }
            }
        }

        protected abstract T GenerateFromDiscriminator(string type, ref Utf8JsonReader reader, JsonSerializerOptions options);

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return LoadFromDiscriminator(ref reader, PropertyName, options);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var newOptions = new JsonSerializerOptions(options);
            newOptions.Converters.Remove(this);
            JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
        }

        private string PropertyName { get; }

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }
    }
}
