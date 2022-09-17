



namespace Alexa.NET.Request.Type
{
    public class SkillEventPersistenceStatus
    {
        [JsonPropertyName("userInformationPersistenceStatus"),
         JsonConverter(typeof(JsonStringEnumConverterEx<PersistenceStatus>))]
        public PersistenceStatus Status { get; set; }
    }
}