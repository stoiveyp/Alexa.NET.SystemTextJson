

namespace Alexa.NET.Response.Directive
{
    public class AudioItem
    {
        
        [JsonPropertyName("stream")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public AudioItemStream Stream { get; set; }

		[JsonPropertyName("metadata")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public AudioItemMetadata Metadata { get; set; }
    }
}
