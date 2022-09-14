
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class SkillResponse
    {
        
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("sessionAttributes")]
        public Dictionary<string, object> SessionAttributes { get; set; }

        
        [JsonPropertyName("response")]
        public ResponseBody Response { get; set; }
    }
}