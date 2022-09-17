

namespace Alexa.NET.Response
{
    public class StandardCard : ICard
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public string Type
        {
            get { return "Standard"; }
        }

        
        [JsonPropertyName("title")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Title { get; set; }

        
        [JsonPropertyName("text")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Content { get; set; }

        [JsonPropertyName("image")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public CardImage Image { get; set; }
    }
}
