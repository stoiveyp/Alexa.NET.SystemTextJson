

namespace Alexa.NET.Response
{
    public class SimpleCard : ICard
    {
        [JsonPropertyName("type")]
        
        public string Type
        {
            get { return "Simple"; }
        }

        [JsonPropertyName("title")]
        
        public string Title { get; set; }

        
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}