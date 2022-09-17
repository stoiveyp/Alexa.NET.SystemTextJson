using Alexa.NET.Request.Type;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request
{
    public class Context
    {
        [JsonPropertyName("System")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public AlexaSystem System { get; set; }
        
        [JsonPropertyName("AudioPlayer")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public PlaybackState AudioPlayer { get; set; }

        [JsonPropertyName("Geolocation")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Geolocation Geolocation { get; set; }
    }
}
