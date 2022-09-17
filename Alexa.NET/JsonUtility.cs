using System;

namespace Alexa.NET.SystemTextJson
{
    public static class JsonUtility
    {
        public static string GetPropertyValue(Utf8JsonReader reader, string propertyName)
        {
            return GetPropertyValue(ref reader, propertyName);
        }

        public static string GetPropertyValue(ref Utf8JsonReader dReader, string propertyName)
        {
            if (!ScanObjectForType(ref dReader, propertyName))
            {
                throw new InvalidOperationException($"Unable to find {propertyName} discriminator");
            }

            return ReadPropertyValue(ref dReader);
        }

        public static string ReadPropertyValue(ref Utf8JsonReader dReader)
        {
            dReader.Read();
            return (dReader.TokenType == JsonTokenType.Number)
                ? dReader.GetInt32().ToString()
                : dReader.GetString();
        }

        public static bool ScanObjectForType(ref Utf8JsonReader dReader, string propertyName, bool skip = false)
        {
            while (skip || dReader.TokenType != JsonTokenType.PropertyName || !dReader.GetString().Equals(propertyName, StringComparison.OrdinalIgnoreCase))
            {
                if (!dReader.Read())
                {
                    return false;
                }

                if (dReader.TokenType == JsonTokenType.StartObject)
                {
                    if (ScanObjectForType(ref dReader, propertyName, true))
                    {
                        return true;
                    }
                }

                else if (dReader.TokenType == JsonTokenType.EndObject)
                {
                    return false;
                }
            }

            return true;
        }

        public static T ReadWithoutConverter<T>(this JsonConverter converter, ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            return (T)ReadWithoutConverter(converter, ref reader, typeof(T), options);
        }

        public static object ReadWithoutConverter(this JsonConverter converter, ref Utf8JsonReader reader,
            Type returnType, JsonSerializerOptions options)
        {
            var newOptions = new JsonSerializerOptions(options);
            newOptions.Converters.Remove(converter);
            return JsonSerializer.Deserialize(ref reader, returnType, newOptions);
        }

        public static void WriteWithoutConverter(this Utf8JsonWriter writer, JsonConverter converter,object value,
            JsonSerializerOptions options)
        {
            var newOptions = new JsonSerializerOptions(options);
            newOptions.Converters.Remove(converter);
            JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
        }
    }
}
