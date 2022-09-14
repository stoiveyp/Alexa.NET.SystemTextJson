
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class SystemExceptionRequest : Request
    {
        [JsonPropertyName("error")]
        public Error Error { get; set; }
        [JsonPropertyName("cause")]
        public ErrorCause ErrorCause { get; set; }
    }
}
