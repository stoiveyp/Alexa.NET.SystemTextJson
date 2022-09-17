using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.Directive;
using Alexa.NET.SystemTextJson;


namespace Alexa.NET.Response
{
    [JsonConverter(typeof(ProgressiveResponseConverter))]
    public interface IProgressiveResponseDirective
    {
        [JsonPropertyName("type")]
        string Type { get; }
    }

    public class ProgressiveResponseConverter:DiscriminatorJsonConverter<IProgressiveResponseDirective>
    {
        public static Dictionary<string, Type> ResponseTypes = new()
        {
            { "VoicePlayer.Speak", typeof(VoicePlayerSpeakDirective) }
        };

        public ProgressiveResponseConverter() : base("type")
        {
        }

        protected override IProgressiveResponseDirective GenerateFromDiscriminator(string type, ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            if (ResponseTypes.ContainsKey(type))
            {
                return (IProgressiveResponseDirective)this.ReadWithoutConverter(ref reader, ResponseTypes[type], options);
            }

            throw new InvalidOperationException($"Unable to deserialize Progressive Response Directive {type}");
        }
    }
}
