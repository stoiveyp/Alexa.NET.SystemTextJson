

namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class Restaurant
    {
        [JsonPropertyName("@type")]
        public string Type => "Restaurant";

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonPropertyName("location")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress Location { get; set; }
    }
}