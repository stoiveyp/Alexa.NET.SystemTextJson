


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PinConfirmationResult
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PinConfirmationStatus Status { get; set; }

        [JsonPropertyName("reason")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PinConfirmationReason Reason { get; set; }
    }
}
