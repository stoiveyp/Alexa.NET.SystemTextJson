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

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type { get; internal set; }

        [JsonExtensionData]
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}
