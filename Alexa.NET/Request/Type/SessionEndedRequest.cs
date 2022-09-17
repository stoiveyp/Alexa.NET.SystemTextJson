


using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Request.Type
{
    public class SessionEndedRequest : Request
    {
        [JsonPropertyName("reason")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<Reason>))]
        public Reason Reason { get; set; }

        [JsonPropertyName("error")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Error Error { get; set; }
    }
}