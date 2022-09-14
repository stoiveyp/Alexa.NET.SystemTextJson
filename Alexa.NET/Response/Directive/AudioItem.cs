

namespace Alexa.NET.Response.Directive
{
    public class AudioItem
    {
        
        [JsonPropertyName("stream")]
        public AudioItemStream Stream { get; set; }

		[JsonPropertyName("metadata")]
		public AudioItemMetadata Metadata { get; set; }
    }
}
