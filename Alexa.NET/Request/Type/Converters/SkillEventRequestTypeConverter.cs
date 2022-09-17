namespace Alexa.NET.Request.Type
{
    public class SkillEventRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "AlexaSkillEvent.SkillPermissionAccepted" ||
                   requestType == "AlexaSkillEvent.SkillPermissionChanged" ||
                   requestType == "AlexaSkillEvent.SkillAccountLinked" ||
                   requestType.StartsWith("AlexaSkillEvent");
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return requestType switch
            {
                "AlexaSkillEvent.SkillAccountLinked" => JsonSerializer.Deserialize<AccountLinkSkillEventRequest>(ref reader, options),
                "AlexaSkillEvent.SkillPermissionAccepted" => JsonSerializer.Deserialize<PermissionSkillEventRequest>(ref reader, options),
                "AlexaSkillEvent.SkillPermissionChanged" => JsonSerializer.Deserialize<PermissionSkillEventRequest>(ref reader, options),
                "AlexaSkillEvent.SkillDisabled" => JsonSerializer.Deserialize<SkillEnablementSkillEventRequest>(ref reader, options),
                "AlexaSkillEvent.SkillEnabled" => JsonSerializer.Deserialize<SkillEnablementSkillEventRequest>(ref reader, options),
                _ => JsonSerializer.Deserialize<SkillEventRequest>(ref reader, options)
            };
        }
    }
}