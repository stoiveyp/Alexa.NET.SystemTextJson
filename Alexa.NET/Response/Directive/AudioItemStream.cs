

namespace Alexa.NET.Response.Directive
{
    public class AudioItemStream
    {
        
        [JsonPropertyName("url")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Url { get; set; }

        
        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }
        
        [JsonPropertyName("expectedPreviousToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ExpectedPreviousToken { get; set; }

        
        [JsonPropertyName("offsetInMilliseconds")]
        public int OffsetInMilliseconds { get; set; }
    }
}
