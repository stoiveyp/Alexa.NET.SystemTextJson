

namespace Alexa.NET.Response.Directive
{
    public class SlotType
    {
        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("values")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public SlotTypeValue[] Values { get; set; }
    }
}