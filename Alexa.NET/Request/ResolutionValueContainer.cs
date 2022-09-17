

namespace Alexa.NET.Request
{
    public class ResolutionValueContainer
    {
        [JsonPropertyName("value")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ResolutionValue Value { get; set; }
    }
}
