

namespace Alexa.NET.ConnectionTasks
{
    public class ConnectionTaskContext
    {
        [JsonPropertyName("providerId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ProviderId { get; set; }
    }
}