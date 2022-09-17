using Alexa.NET.ConnectionTasks;


namespace Alexa.NET.Request.Type
{
    public class LaunchRequestTask
    {
        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("version")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Version { get; set; }

        [JsonPropertyName("input")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public IConnectionTask Input { get; set; }
    }
}