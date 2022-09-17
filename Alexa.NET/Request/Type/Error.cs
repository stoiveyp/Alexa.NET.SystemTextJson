

using Alexa.NET.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class Error
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<ErrorType>))]
        public ErrorType Type { get; set; }

        [JsonPropertyName("message")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; }
    }
}
