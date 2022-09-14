

namespace Alexa.NET.Response.Directive
{
    public class VideoItem
    {
        public VideoItem(string source)
        {
            Source = source;
        }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("metadata")]
        public VideoItemMetadata Metadata { get; set; }
    }
}
