using Alexa.NET.Request;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PinConfirmation:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.VerifyPerson/2";

        //https://developer.amazon.com/en-US/docs/alexa/custom-skills/pin-confirmation-for-alexa-skills.html#connections-startconnection-format
        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("requestedAuthenticationConfidenceLevel")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public AuthenticationConfidenceLevel RequestedAuthenticationConfidenceLevel { get; } =
            new()
            { 
                Level = 400, 
                Custom = new AuthenticationConfidenceLevelCustomPolicy("VOICE_PIN")

            };
    }
}
