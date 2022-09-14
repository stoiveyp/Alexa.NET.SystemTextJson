

namespace Alexa.NET.Response.Directive
{
    public class AudioItemStream
    {
        
        [JsonPropertyName("url")]
        public string Url { get; set; }

        
        [JsonPropertyName("token")]
        public string Token { get; set; }
        
        [JsonPropertyName("expectedPreviousToken")]
        public string ExpectedPreviousToken { get; set; }

        
        [JsonPropertyName("offsetInMilliseconds")]
        public int OffsetInMilliseconds { get; set; }
    }
}
