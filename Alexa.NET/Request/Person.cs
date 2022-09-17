

namespace Alexa.NET.Request
{
    public class Person
    {
        [JsonPropertyName("personId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PersonId { get; set; }

        [JsonPropertyName("accessToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string AccessToken { get; set; }

        [JsonPropertyName("authenticationConfidenceLevel")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public AuthenticationConfidenceLevel AuthenticationConfidenceLevel { get; set; }
    }
}