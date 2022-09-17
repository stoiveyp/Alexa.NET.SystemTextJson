

namespace Alexa.NET.Request
{
    public class ResolutionStatus
    {
        [JsonPropertyName("code")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Code { get; set; }
    }
}
