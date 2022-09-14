using System;
using Alexa.NET.Response.Converters;


namespace Alexa.NET.Response.Directive
{
    [JsonConverter(typeof(TemplateConverter))]
    [Obsolete("Display Templates are deprecated as of August 31st 2021. For more information visit https://developer.amazon.com/en-US/blogs/alexa/alexa-skills-kit/2021/06/-goodbye-display-templates--hello-alexa-responsive-templates")]
    public interface ITemplate
    {
        [JsonPropertyName("type")]
        string Type { get; }

        [JsonPropertyName("token")]
        string Token { get; set; }
    }
}