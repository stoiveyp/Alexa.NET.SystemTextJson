﻿

namespace Alexa.NET.Request.Type
{
    public class SkillEventPermissions
    {
        [JsonPropertyName("acceptedPermissions")]
        public Permission[] AcceptedPermissions { get; set; }
    }
}