

namespace Alexa.NET.Request
{
    public class Slot
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("confirmationStatus")]
        public string ConfirmationStatus { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("resolutions")]
        public Resolution Resolution { get; set; }

        [JsonPropertyName("slotValue")]
        public SlotValue SlotValue { get; set; }
    }
}