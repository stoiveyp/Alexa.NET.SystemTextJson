﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Response
{
    public class ProgressiveResponseRequest
    {
        public ProgressiveResponseRequest()
        {
        }

        public ProgressiveResponseRequest(ProgressiveResponseHeader header, IProgressiveResponseDirective directive)
        {
            Header = header;
            Directive = directive;
        }

        [JsonPropertyName("header")]
        public ProgressiveResponseHeader Header { get; set; }

        [JsonPropertyName("directive")]
        public IProgressiveResponseDirective Directive { get; set; }
    }
}
