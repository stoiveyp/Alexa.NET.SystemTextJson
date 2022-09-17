

namespace Alexa.NET.Request
{
    public class Scope
    {
        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Status { get; set; }
    }
}
