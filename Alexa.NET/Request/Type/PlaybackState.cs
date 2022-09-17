
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class PlaybackState
    {
        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }

        [JsonPropertyName("offsetInMilliseconds")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public long OffsetInMilliseconds { get; set; }

        [JsonPropertyName("playerActivity")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PlayerActivity { get; set; }
    }
}
