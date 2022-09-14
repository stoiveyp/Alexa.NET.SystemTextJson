﻿

namespace Alexa.NET.Response.Directive
{
    public class SlotType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("values")]
        public SlotTypeValue[] Values { get; set; }
    }
}