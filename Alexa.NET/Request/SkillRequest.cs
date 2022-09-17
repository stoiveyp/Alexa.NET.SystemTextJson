using Alexa.NET.Request.Type;


namespace Alexa.NET.Request
{
    public class SkillRequest
    {
        [JsonPropertyName("version")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Version { get; set; }

        [JsonPropertyName("session")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Session Session { get; set; }

        [JsonPropertyName("context")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Context Context { get; set; }

        [JsonPropertyName("request")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Type.Request Request { get; set; }

        public System.Type GetRequestType()
        {
            return Request?.GetType();
        }
    }
}