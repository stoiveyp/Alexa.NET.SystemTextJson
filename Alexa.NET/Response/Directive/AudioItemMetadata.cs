using System.Collections.Generic;


namespace Alexa.NET.Response.Directive
{
    public class AudioItemMetadata
    {
		[JsonPropertyName("title")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Title { get; set; }

        [JsonPropertyName("subtitle")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public string Subtitle { get; set; }

		[JsonPropertyName("art")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public AudioItemSources Art { get; set; } = new();

		[JsonPropertyName("backgroundImage")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public AudioItemSources BackgroundImage { get; set; } = new();
    }
}