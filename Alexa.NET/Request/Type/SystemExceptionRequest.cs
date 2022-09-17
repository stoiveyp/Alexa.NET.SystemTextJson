
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class SystemExceptionRequest : Request
    {
        [JsonPropertyName("error")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Error Error { get; set; }
        [JsonPropertyName("cause")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ErrorCause ErrorCause { get; set; }
    }
}
