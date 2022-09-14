using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Response.Directive.Templates.Types
{
    [Obsolete("Display Templates are deprecated as of August 31st 2021. For more information visit https://developer.amazon.com/en-US/blogs/alexa/alexa-skills-kit/2021/06/-goodbye-display-templates--hello-alexa-responsive-templates")]
    public class BodyTemplate2:IBodyTemplate
    {
        public string Type => "BodyTemplate2";
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("image")]
        public TemplateImage Image { get; set; }

        [JsonPropertyName("textContent")]
        public TemplateContent Content { get; set; }
    }
}
