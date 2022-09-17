

namespace Alexa.NET.Response.Directive
{
    public class ConnectionSendRequest<T> : ConnectionSendRequest
    {
        [JsonPropertyName("payload")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public T Payload { get; set; }
    }

    public class ConnectionSendRequest:IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string Type => "Connections.SendRequest";

        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string Name { get; set; }

        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        string Token { get; set; }
    }
}