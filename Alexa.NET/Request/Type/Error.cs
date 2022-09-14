

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class Error
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ErrorType Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
