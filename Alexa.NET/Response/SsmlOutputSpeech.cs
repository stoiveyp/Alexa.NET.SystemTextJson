using Alexa.NET.Response.Directive;


namespace Alexa.NET.Response
{
    public class SsmlOutputSpeech : IOutputSpeech
    {
        public SsmlOutputSpeech()
        {

        }

        public SsmlOutputSpeech(string ssml)
        {
            Ssml = ssml;
        }

        
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type
        {
            get { return "SSML"; }
        }

        
        [JsonPropertyName("ssml")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Ssml { get; set; }

        [JsonPropertyName("playBehavior")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(JsonStringEnumConverterEx<PlayBehavior>))]
        public PlayBehavior? PlayBehavior { get; set; }
    }
}