using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogConfirmSlot : IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Dialog.ConfirmSlot";

        [JsonPropertyName("slotToConfirm")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string SlotName { get; set; }

        [JsonPropertyName("updatedIntent")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Intent UpdatedIntent { get; set; }

        public DialogConfirmSlot(string slotName)
        {
            SlotName = slotName;
        }

        internal DialogConfirmSlot()
        {
        }
    }
}