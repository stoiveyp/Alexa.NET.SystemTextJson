using System;
using System.Collections.Generic;


namespace Alexa.NET.Response.Directive
{
    public interface IListTemplate : ITemplate
    {
        [JsonPropertyName("listItems")]
        List<ListItem> Items { get; set; }
    }
}
