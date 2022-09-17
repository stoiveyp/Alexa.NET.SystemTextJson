
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class SkillResponse
    {
        
        [JsonPropertyName("version")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Version { get; set; }

        [JsonPropertyName("sessionAttributes")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object> SessionAttributes { get; set; }

        
        [JsonPropertyName("response")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ResponseBody Response { get; set; }
    }
}