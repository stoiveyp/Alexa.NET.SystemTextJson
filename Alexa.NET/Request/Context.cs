using Alexa.NET.Request.Type;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request
{
    public class Context
    {
        [JsonPropertyName("System")]
        public AlexaSystem System { get; set; }
        
        [JsonPropertyName("AudioPlayer")]
        public PlaybackState AudioPlayer { get; set; }

        [JsonPropertyName("Geolocation")]
        public Geolocation Geolocation { get; set; }
    }
}
