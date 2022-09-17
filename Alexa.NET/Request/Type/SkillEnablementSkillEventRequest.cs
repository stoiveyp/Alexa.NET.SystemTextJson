using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class SkillEnablementSkillEventRequest: SkillEventRequest
    {
        [JsonPropertyName("body")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public SkillEventPersistenceStatus Body { get; set; }
    }
}
