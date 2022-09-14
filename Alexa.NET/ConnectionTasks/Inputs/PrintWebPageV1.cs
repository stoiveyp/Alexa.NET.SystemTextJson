﻿using System;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PrintWebPageV1:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.PrintWebPage/1";

        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("@type")]
        public string Type => "PrintWebPageRequest";

        [JsonPropertyName("context")]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

    }
}
