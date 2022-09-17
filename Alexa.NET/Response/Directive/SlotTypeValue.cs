

namespace Alexa.NET.Response.Directive
{
    public class SlotTypeValue
    {
        [JsonPropertyName("id")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Id { get; set; }

        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public SlotTypeValueName Name { get; set; }
    }
}