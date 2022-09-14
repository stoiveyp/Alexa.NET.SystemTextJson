

namespace Alexa.NET.Response.Directive.Templates
{
    public class ImageSource
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("widthPixels")]
        public int Width { get; set; }

        [JsonPropertyName("heightPixels")]
        public int Height { get; set; }

        public bool ShouldSerializeWidth()
        {
            return Width > 0;
        }

        public bool ShouldSerializeHeight()
        {
            return Height > 0;
        }
    }
}