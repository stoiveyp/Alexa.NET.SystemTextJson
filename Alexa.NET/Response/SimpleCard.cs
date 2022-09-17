

namespace Alexa.NET.Response
{
    public class SimpleCard : ICard
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public string Type
        {
            get { return "Simple"; }
        }

        [JsonPropertyName("title"),JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public string Title { get; set; }

        
        [JsonPropertyName("content")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Content { get; set; }
    }
}