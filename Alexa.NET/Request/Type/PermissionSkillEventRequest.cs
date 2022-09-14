using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class PermissionSkillEventRequest:SkillEventRequest
    {
        [JsonPropertyName("body")]
        public SkillEventPermissions Body { get; set; }
    }
}
