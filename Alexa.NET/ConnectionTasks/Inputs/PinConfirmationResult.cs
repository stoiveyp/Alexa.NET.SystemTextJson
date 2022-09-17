


using Alexa.NET.SystemTextJson;
using System.Text.Json.Serialization;

namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PinConfirmationResult
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<PinConfirmationStatus>))]
        public PinConfirmationStatus Status { get; set; }

        [JsonPropertyName("reason")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<PinConfirmationReason>))]
        public PinConfirmationReason Reason { get; set; }
    }
}
