

namespace Alexa.NET.Request.Type
{
    public class IntentRequest : Request
    {
        [JsonPropertyName("dialogState")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string DialogState { get; set; }

        [JsonPropertyName("intent")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Intent Intent { get; set; }
    }
}