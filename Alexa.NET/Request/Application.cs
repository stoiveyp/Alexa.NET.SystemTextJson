

namespace Alexa.NET.Request
{
    public class Application
    {
        [JsonPropertyName("applicationId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ApplicationId { get; set; }
    }
}
