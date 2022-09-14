


namespace Alexa.NET.Request.Type
{
    public class SessionEndedRequest : Request
    {
        [JsonPropertyName("reason")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Reason Reason { get; set; }

        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}