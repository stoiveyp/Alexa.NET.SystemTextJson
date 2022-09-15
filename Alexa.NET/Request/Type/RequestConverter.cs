

using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Request.Type
{
    public class RequestConverter : DiscriminatorJsonConverter<Request>
    {
        public static readonly List<IRequestTypeConverter> RequestConverters = new(new IRequestTypeConverter[]
        {
            new DefaultRequestTypeConverter(),
            new AudioPlayerRequestTypeConverter(),
            new PlaybackRequestTypeConverter(),
            new TemplateEventRequestTypeConverter(),
            new SkillEventRequestTypeConverter(),
            new SkillConnectionRequestTypeConverter(),
            new ConnectionResponseTypeConverter()
        });

        public RequestConverter():base("type"){}

        public override bool CanConvert(System.Type objectType)
        {
            return objectType == typeof(Request);
        }

        protected override Request GenerateFromDiscriminator(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            var converter = RequestConverters.FirstOrDefault(c => c.CanConvert(requestType));
            return converter switch
            {
                null =>
                    throw new ArgumentOutOfRangeException(nameof(Type), $"Unknown request type: {requestType}."),
                IDataDrivenRequestTypeConverter dataDriven => dataDriven.Convert(requestType, ref reader, options),
                _ => converter.Convert(requestType, ref reader, options)
            };
        }
    }
}