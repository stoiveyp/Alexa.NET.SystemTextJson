
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class PlaybackState
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

        [JsonPropertyName("playerActivity")]
        public string PlayerActivity { get; set; }
    }
}
