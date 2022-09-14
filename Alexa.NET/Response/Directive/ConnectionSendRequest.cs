

namespace Alexa.NET.Response.Directive
{
    public class ConnectionSendRequest<T> : ConnectionSendRequest
    {
        [JsonPropertyName("payload")]
        public T Payload { get; set; }
    }

    public class ConnectionSendRequest:IDirective
    {
        [JsonPropertyName("type")] public string Type => "Connections.SendRequest";

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("token")]
        string Token { get; set; }
    }
}