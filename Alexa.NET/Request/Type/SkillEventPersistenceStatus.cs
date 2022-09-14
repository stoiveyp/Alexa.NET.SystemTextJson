


namespace Alexa.NET.Request.Type
{
    public class SkillEventPersistenceStatus
    {
        [JsonPropertyName("userInformationPersistenceStatus"),
         JsonConverter(typeof(JsonStringEnumConverter))]
        public PersistenceStatus Status { get; set; }
    }
}