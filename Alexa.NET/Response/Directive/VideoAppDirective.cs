

namespace Alexa.NET.Response.Directive
{
    public class VideoAppDirective:IEndSessionDirective
    {
        public VideoAppDirective()
        {
        }

        public VideoAppDirective(string source)
        {
            VideoItem = new VideoItem(source);
        }

        [JsonPropertyName("type")]
        public string Type => "VideoApp.Launch";

        [JsonPropertyName("videoItem")]
        public VideoItem VideoItem { get; set; }

        public bool? ShouldEndSession => null;
    }
}
