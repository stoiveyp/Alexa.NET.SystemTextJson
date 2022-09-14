

namespace Alexa.NET.Response
{
    public class LinkAccountCard : ICard
    {
        [JsonPropertyName("type")]
        public string Type
        {
            get { return "LinkAccount"; }
        }
    }
}