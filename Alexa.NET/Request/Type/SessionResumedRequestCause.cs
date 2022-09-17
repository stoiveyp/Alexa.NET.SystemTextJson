using Alexa.NET.ConnectionTasks;


namespace Alexa.NET.Request.Type
{
    public class SessionResumedRequestCause
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type { get; set; }

        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }

        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionStatus Status { get; set; }

        [JsonPropertyName("result")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public object Result { get; set; }
    }
}