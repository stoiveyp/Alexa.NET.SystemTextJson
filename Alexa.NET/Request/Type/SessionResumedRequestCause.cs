﻿using Alexa.NET.ConnectionTasks;


namespace Alexa.NET.Request.Type
{
    public class SessionResumedRequestCause
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("status")]
        public ConnectionStatus Status { get; set; }

        [JsonPropertyName("result")]
        public object Result { get; set; }
    }
}