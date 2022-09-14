using System;

using System.Collections.Generic;
using System.Linq;

namespace Alexa.NET.Response
{
    public class ResponseBody
    {
        [JsonPropertyName("outputSpeech")]
        public IOutputSpeech OutputSpeech { get; set; }

        [JsonPropertyName("card")]
        public ICard Card { get; set; }

        [JsonPropertyName("reprompt")]
        public Reprompt Reprompt { get; set; }

        private bool? _shouldEndSession = false;

        [JsonPropertyName("shouldEndSession")]
        public bool? ShouldEndSession
        {
            get
            {
                var overrideDirectives = Directives?.OfType<IEndSessionDirective>();
                if (overrideDirectives == null || !overrideDirectives.Any())
                {
                    return _shouldEndSession;
                }

                var first = overrideDirectives.First().ShouldEndSession;
                if (!overrideDirectives.All(od => od.ShouldEndSession == first))
                {
                    return _shouldEndSession;
                }

                return first;

            }
            set => _shouldEndSession = value;
        }

        [JsonPropertyName("directives")]
        public IList<IDirective> Directives { get; set; } = new List<IDirective>();

        public bool ShouldSerializeDirectives()
        {
            return Directives.Count > 0;
        }
    }
}
