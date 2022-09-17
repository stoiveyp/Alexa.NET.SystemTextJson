using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class AccountLinkSkillEventRequest:SkillEventRequest
    {
        [JsonPropertyName("body")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public AccountLinkSkillEventDetail Body { get; set; }
    }
}
