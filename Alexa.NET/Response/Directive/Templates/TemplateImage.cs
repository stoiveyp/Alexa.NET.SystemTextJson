using System.Collections.Generic;


namespace Alexa.NET.Response.Directive.Templates
{
    public class TemplateImage
    {
        [JsonPropertyName("contentDescription")]
        public string ContentDescription { get; set; }

        [JsonPropertyName("sources")]
        public List<ImageSource> Sources {get;set;} = new();
    }
}