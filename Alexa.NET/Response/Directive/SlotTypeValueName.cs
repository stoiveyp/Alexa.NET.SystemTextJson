

namespace Alexa.NET.Response.Directive
{
    public class SlotTypeValueName
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("synonyms")]
        public string[] Synonyms { get; set; }
    }
}