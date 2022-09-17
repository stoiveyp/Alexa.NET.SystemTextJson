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

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public string Type
        {
            get { return "PlainText"; }
        }

        
        [JsonPropertyName("text")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Text { get; set; }

        [JsonPropertyName("playBehavior")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(JsonStringEnumConverterEx<PlayBehavior>))]
        public PlayBehavior? PlayBehavior { get; set; }
    }
}