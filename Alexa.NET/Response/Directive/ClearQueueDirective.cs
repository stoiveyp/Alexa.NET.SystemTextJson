﻿namespace Alexa.NET.Response.Directive
{
    public class ClearQueueDirective : IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "AudioPlayer.ClearQueue";

        [JsonPropertyName("clearBehavior")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        [JsonConverter(typeof(JsonStringEnumConverterEx<ClearBehavior>))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}
