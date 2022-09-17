

namespace Alexa.NET.Request
{
    public class User
    {
        [JsonPropertyName("userId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string UserId { get; set; }

        [JsonPropertyName("accessToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string AccessToken { get; set; }

        [JsonPropertyName("permissions")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Permissions Permissions { get; set; }
    }
}