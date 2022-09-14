


namespace Alexa.NET.Response.Directive
{
    public class AudioPlayerPlayDirective : IDirective
    {
        [JsonPropertyName("playBehavior")]
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayBehavior PlayBehavior { get; set; }

        [JsonPropertyName("audioItem")]
        
        public AudioItem AudioItem { get; set; }

        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.Play";
    }
}
