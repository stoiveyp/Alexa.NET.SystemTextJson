using Alexa.NET.Response.Directive;



namespace Alexa.NET.Response
{
    public class PlainTextOutputSpeech : IOutputSpeech
    {
        public PlainTextOutputSpeech()
        {

        }

        public PlainTextOutputSpeech(string text)
        {
            Text = text;
        }

        [JsonPropertyName("type")]
        
        public string Type
        {
            get { return "PlainText"; }
        }

        
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("playBehavior")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayBehavior? PlayBehavior { get; set; }
    }
}