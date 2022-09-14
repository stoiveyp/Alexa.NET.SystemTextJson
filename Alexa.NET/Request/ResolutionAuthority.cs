

namespace Alexa.NET.Request
{
    public class ResolutionAuthority
    {
        [JsonPropertyName("authority")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public ResolutionStatus Status { get; set; }

        [JsonPropertyName("values")]
        public ResolutionValueContainer[] Values { get; set; }
    }
}
