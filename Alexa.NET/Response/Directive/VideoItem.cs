

namespace Alexa.NET.Response.Directive
{
    public class VideoItem
    {
        public VideoItem(string source)
        {
            Source = source;
        }

        [JsonPropertyName("source")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Source { get; set; }

        [JsonPropertyName("metadata")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public VideoItemMetadata Metadata { get; set; }
    }
}
