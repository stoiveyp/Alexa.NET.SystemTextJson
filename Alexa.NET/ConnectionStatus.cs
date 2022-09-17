using System.Text.Json.Serialization;


namespace Alexa.NET
{
    public class ConnectionStatus
    {
        public ConnectionStatus() { }

        public ConnectionStatus(int code, string message)
        {
            Code = code;
            Message = message;
        }

        [JsonPropertyName("code")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public int Code { get; set; }

        [JsonPropertyName("message")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; }
    }
}