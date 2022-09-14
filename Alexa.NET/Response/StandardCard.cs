

namespace Alexa.NET.Response
{
    public class StandardCard : ICard
    {
        [JsonPropertyName("type")]
        
        public string Type
        {
            get { return "Standard"; }
        }

        
        [JsonPropertyName("title")]
        public string Title { get; set; }

        
        [JsonPropertyName("text")]
        public string Content { get; set; }

        [JsonPropertyName("image")]
        public CardImage Image { get; set; }
    }
}
