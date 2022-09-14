using System.Collections.Generic;



namespace Alexa.NET.Response.Directive
{
    public class DialogUpdateDynamicEntities : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.UpdateDynamicEntities";

        [JsonPropertyName("updateBehavior"), JsonConverter(typeof(JsonStringEnumConverter))]
        public UpdateBehavior UpdateBehavior { get; set; }

        [JsonPropertyName("types")]
        public List<SlotType> Types { get; set; } = new();
    }
}
