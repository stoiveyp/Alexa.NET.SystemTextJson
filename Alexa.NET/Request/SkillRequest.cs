﻿using Alexa.NET.Request.Type;


namespace Alexa.NET.Request
{
    public class SkillRequest
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("session")]
        public Session Session { get; set; }

        [JsonPropertyName("context")]
        public Context Context { get; set; }

        [JsonPropertyName("request")]
        public Type.Request Request { get; set; }

        public System.Type GetRequestType()
        {
            return Request?.GetType();
        }
    }
}