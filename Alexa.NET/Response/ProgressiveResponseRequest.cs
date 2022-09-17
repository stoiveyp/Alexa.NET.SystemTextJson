using System;
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

        [JsonPropertyName("header")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ProgressiveResponseHeader Header { get; set; }

        [JsonPropertyName("directive")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IProgressiveResponseDirective Directive { get; set; }
    }
}
