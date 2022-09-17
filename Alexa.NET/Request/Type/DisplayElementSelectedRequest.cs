using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.Request.Type
{
    public class DisplayElementSelectedRequest:Request
    {
        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }
    }
}
