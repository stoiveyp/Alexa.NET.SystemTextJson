


namespace Alexa.NET.Request
{
    public class SlotValue
    {
        [JsonPropertyName("type"),
         JsonConverter(typeof(JsonStringEnumConverter))]
        public SlotValueType SlotType { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("values")]
        public SlotValue[] Values { get; set; }

        [JsonPropertyName("resolutions")]
        public Resolution Resolutions { get; set; }
    }
}