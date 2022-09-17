using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.SystemTextJson;


namespace Alexa.NET.Response.Converters
{
    public class OutputSpeechConverter : DiscriminatorJsonConverter<IOutputSpeech>
    {
        public static Dictionary<string, Type> TypeFactories = new()
        {
            { "SSML", typeof(SsmlOutputSpeech) },
            { "PlainText", typeof(PlainTextOutputSpeech) },
        };

        public OutputSpeechConverter() : base("type")
        {
        }

        protected override IOutputSpeech GenerateFromDiscriminator(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            if(!TypeFactories.TryGetValue(type, out var returnType))
                throw new Exception(
                    $"unable to deserialize response. " +
                    $"unrecognized output speech type '{type}'"
                );

            return (IOutputSpeech)JsonSerializer.Deserialize(ref reader, returnType, options);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IOutputSpeech);
        }
    }
}