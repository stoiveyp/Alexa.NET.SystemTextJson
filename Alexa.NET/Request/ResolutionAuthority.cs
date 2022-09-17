

namespace Alexa.NET.Request
{
    public class ResolutionAuthority
    {
        [JsonPropertyName("authority")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ResolutionStatus Status { get; set; }

        [JsonPropertyName("values")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ResolutionValueContainer[] Values { get; set; }
    }
}
