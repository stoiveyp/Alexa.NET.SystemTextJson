

namespace Alexa.NET.Response
{
    public class CardImage
    {
        [JsonPropertyName("smallImageUrl")]
        public string SmallImageUrl { get; set; }

        [JsonPropertyName("largeImageUrl")]
        public string LargeImageUrl { get; set; }
    }
}
