

namespace Alexa.NET.Response
{
    public class LinkAccountCard : ICard
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type
        {
            get { return "LinkAccount"; }
        }
    }
}