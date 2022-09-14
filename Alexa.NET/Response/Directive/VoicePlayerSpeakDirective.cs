using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Response.Directive
{
    public class VoicePlayerSpeakDirective : IProgressiveResponseDirective
    {
        internal VoicePlayerSpeakDirective()
        {
        }

        public VoicePlayerSpeakDirective(Ssml.Speech speech) : this(speech.ToXml())
        {
        }

        public VoicePlayerSpeakDirective(string speech)
        {
            Speech = speech;
        }

        [JsonPropertyName("type")]
        public string Type => "VoicePlayer.Speak";

        [JsonPropertyName("speech")]
        public string Speech { get; }
    }
}
