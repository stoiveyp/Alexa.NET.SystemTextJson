using System;


namespace Alexa.NET.Response.Directive.Templates
{
    public class TemplateText
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
