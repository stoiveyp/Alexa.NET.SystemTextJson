﻿

namespace Alexa.NET.Request.Type
{
    public class Permission
    {
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}