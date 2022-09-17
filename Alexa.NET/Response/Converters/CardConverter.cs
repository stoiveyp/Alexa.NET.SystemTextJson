

using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Response.Converters
{
    public class CardConverter : DiscriminatorJsonConverter<ICard>
    {
        public static Dictionary<string, Type> TypeFactories = new()
        {
            { "Simple", typeof(SimpleCard) },
            { "Standard", typeof(StandardCard) },
            { "LinkAccount", typeof(LinkAccountCard) },
            { "AskForPermissionsConsent", typeof(AskForPermissionsConsentCard) }
        };

        public CardConverter():base("type"){}

        protected override ICard GenerateFromDiscriminator(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            if (!TypeFactories.TryGetValue(type, out var returnType))
                throw new Exception(
                    $"unable to deserialize response. " +
                    $"unrecognized card type '{type}'"
                );

            return (ICard)JsonSerializer.Deserialize(ref reader, returnType, options);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ICard);
        }
    }
}