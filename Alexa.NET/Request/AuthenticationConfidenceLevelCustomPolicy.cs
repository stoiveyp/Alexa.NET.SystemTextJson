

namespace Alexa.NET.Request
{
    public class AuthenticationConfidenceLevelCustomPolicy
    {
        public AuthenticationConfidenceLevelCustomPolicy(){}

        public AuthenticationConfidenceLevelCustomPolicy(string policyName)
        {
            PolicyName = policyName;
        }

        [JsonPropertyName("policyName")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PolicyName { get; set; }
    }
}