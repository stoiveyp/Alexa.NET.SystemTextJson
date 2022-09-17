using System;
using System.Collections.Generic;
using System.Text;



namespace Alexa.NET.Request.Type
{
    public class SessionResumedRequest:Request
    {
        [JsonPropertyName("originIpAddress")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string OriginIpAddress { get; set; }

        [JsonPropertyName("cause")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public SessionResumedRequestCause Cause { get; set; }
    }
}
