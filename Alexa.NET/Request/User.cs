

namespace Alexa.NET.Request
{
    public class User
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }
}