
using System;
using Alexa.NET.Helpers;

namespace Alexa.NET.Request.Type
{
    [JsonConverter(typeof(RequestConverter))]
    public abstract class Request
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type { get; set; }

        [JsonPropertyName("requestId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string RequestId { get; set; }

        [JsonPropertyName("locale")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Locale { get; set; }

        [JsonPropertyName("timestamp"),JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}