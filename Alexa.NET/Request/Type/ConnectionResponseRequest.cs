

namespace Alexa.NET.Request.Type
{
    public class ConnectionResponseRequest<T> : ConnectionResponseRequest
    {
        [JsonPropertyName("payload")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public T Payload { get; set; }
    }

    public class ConnectionResponseRequest:Request
    {
        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionStatus Status { get; set; }

        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }
    }
}