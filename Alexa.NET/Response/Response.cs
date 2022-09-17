﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Alexa.NET.Response
{
    public class ResponseBody
    {
        [JsonPropertyName("outputSpeech")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public IOutputSpeech OutputSpeech { get; set; }

        [JsonPropertyName("card")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ICard Card { get; set; }

        [JsonPropertyName("reprompt")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Reprompt Reprompt { get; set; }

        private bool? _shouldEndSession = false;

        [JsonPropertyName("shouldEndSession")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonConverter(typeof(EmptyListConverter<IDirective>))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        
        public IList<IDirective> Directives { get; set; } = new List<IDirective>();
    }
}
