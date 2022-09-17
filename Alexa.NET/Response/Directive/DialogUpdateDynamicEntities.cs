using System.Collections.Generic;



namespace Alexa.NET.Response.Directive
{
    public class DialogUpdateDynamicEntities : IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Dialog.UpdateDynamicEntities";

        [JsonPropertyName("updateBehavior"), JsonConverter(typeof(JsonStringEnumConverterEx<UpdateBehavior>))]
        public UpdateBehavior UpdateBehavior { get; set; }

        [JsonPropertyName("types")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public List<SlotType> Types { get; set; } = new();
    }
}
