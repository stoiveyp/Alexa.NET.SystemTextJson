using System.Collections.Generic;


namespace Alexa.NET.Response
{
    public class Reprompt
    {
        public Reprompt()
        {
        }

        public Reprompt(string text)
        {
            OutputSpeech = new PlainTextOutputSpeech {Text = text};
        }

        public Reprompt(Ssml.Speech speech)
        {
            OutputSpeech = new SsmlOutputSpeech {Ssml = speech.ToXml()};
        }

        [JsonPropertyName("outputSpeech")]
        public IOutputSpeech OutputSpeech { get; set; }

        [JsonPropertyName("directives")]
        public IList<IDirective> Directives { get; set; } = new List<IDirective>();

        public bool ShouldSerializeDirectives()
        {
            return Directives.Count > 0;
        }
    }
}