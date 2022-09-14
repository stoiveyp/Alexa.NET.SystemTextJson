using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class AccountLinkSkillEventRequest:SkillEventRequest
    {
        [JsonPropertyName("body")]
        public AccountLinkSkillEventDetail Body { get; set; }
    }
}
