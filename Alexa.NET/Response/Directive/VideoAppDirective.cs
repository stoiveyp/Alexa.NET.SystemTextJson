

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

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "VideoApp.Launch";

        [JsonPropertyName("videoItem")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public VideoItem VideoItem { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ShouldEndSession => null;
    }
}
