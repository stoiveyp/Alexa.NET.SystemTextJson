using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Response.Directive.Templates.Types
{
    [Obsolete("Display Templates are deprecated as of August 31st 2021. For more information visit https://developer.amazon.com/en-US/blogs/alexa/alexa-skills-kit/2021/06/-goodbye-display-templates--hello-alexa-responsive-templates")]
    public class ListTemplate2:IListTemplate
    {
        public string Type => "ListTemplate2";
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        public List<ListItem> Items { get; set; } = new();

        public bool ShouldSerializeItems()
        {
            return Items.Count > 0;
        }
    }
}
