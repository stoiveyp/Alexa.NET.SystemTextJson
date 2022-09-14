﻿using System;


namespace Alexa.NET.Response.Directive
{
    [Obsolete("Display Templates are deprecated as of August 31st 2021. For more information visit https://developer.amazon.com/en-US/blogs/alexa/alexa-skills-kit/2021/06/-goodbye-display-templates--hello-alexa-responsive-templates")]
    public class DisplayRenderTemplateDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Display.RenderTemplate";

        [JsonPropertyName("template")]
        public ITemplate Template { get; set; }
    }
}