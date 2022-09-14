

namespace Alexa.NET.Request.Type
{
    public class LaunchRequest : Request
    {
        [JsonPropertyName("task")]
        public LaunchRequestTask Task { get; set; }
    }
}