using System.Collections.Generic;


namespace Alexa.NET.Request
{
    public class AuthenticationConfidenceLevel
    {
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("customPolicy")]
        public AuthenticationConfidenceLevelCustomPolicy Custom { get; set; }
    }
}