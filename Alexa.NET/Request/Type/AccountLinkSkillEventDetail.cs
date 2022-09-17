

namespace Alexa.NET.Request.Type
{
    public class AccountLinkSkillEventDetail
    {
        [JsonPropertyName("accessToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string AccessToken { get; set; }
    }
}