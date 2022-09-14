

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Response.Directive
{
    public class ClearQueueDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.ClearQueue";

        [JsonPropertyName("clearBehavior")]
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}
