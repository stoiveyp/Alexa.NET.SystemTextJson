

namespace Alexa.NET.Request
{
    public class ResolutionValue
    {
        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("id")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Id { get; set; }
    }
}
