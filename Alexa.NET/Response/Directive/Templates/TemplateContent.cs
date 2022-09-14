using System;


namespace Alexa.NET.Response.Directive.Templates
{
    public class TemplateContent
    {
        [JsonPropertyName("primaryText")]
        public TemplateText Primary { get; set; }

        [JsonPropertyName("secondaryText")]
        public TemplateText Secondary { get; set; }

        [JsonPropertyName("tertiaryText")]
        public TemplateText Tertiary { get; set; }
    }
}
