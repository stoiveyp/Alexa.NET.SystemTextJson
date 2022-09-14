namespace Alexa.NET.Response.Directive
{
    public class VideoItemMetadata
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }
    }
}