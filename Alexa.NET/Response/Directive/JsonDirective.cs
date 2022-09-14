using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Response.Directive
{
    public class JsonDirective:IDirective
    {
        public JsonDirective() { }

        public JsonDirective(string type)
        {
            Type = type;
        }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonExtensionData]
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}
