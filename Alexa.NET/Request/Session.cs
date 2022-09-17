
using System.Collections.Generic;

namespace Alexa.NET.Request
{
    public class Session
    {
        [JsonPropertyName("new")]
        public bool New { get; set; }

        [JsonPropertyName("sessionId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string SessionId { get; set; }

        [JsonPropertyName("attributes")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object> Attributes { get; set; }

        [JsonPropertyName("application")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Application Application { get; set; }

        [JsonPropertyName("user")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public User User { get; set; }
    }
}