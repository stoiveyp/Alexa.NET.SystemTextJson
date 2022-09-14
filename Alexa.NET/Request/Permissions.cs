﻿using System;
using System.Collections.Generic;


namespace Alexa.NET.Request
{
    public class Permissions
    {
        [JsonPropertyName("consentToken"),Obsolete("ConsentToken is deprecated, please use SkillRequest.Context.System.ApiAccessToken")]
        public string ConsentToken { get; set; }

        [JsonPropertyName("scopes")]
        public Dictionary<string, Scope> Scopes { get; set; }
    }
}