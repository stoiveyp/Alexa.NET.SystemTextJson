
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class ErrorCause
    {
        [JsonPropertyName("requestId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string requestId { get; set; }
    }
}
