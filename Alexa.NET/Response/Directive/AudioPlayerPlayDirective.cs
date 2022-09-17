


using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Response.Directive
{
    public class AudioPlayerPlayDirective : IDirective
    {
        [JsonPropertyName("playBehavior")]
        
        [JsonConverter(typeof(JsonStringEnumConverterEx<PlayBehavior>))]
        public PlayBehavior PlayBehavior { get; set; }

        [JsonPropertyName("audioItem")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public AudioItem AudioItem { get; set; }

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "AudioPlayer.Play";
    }
}
