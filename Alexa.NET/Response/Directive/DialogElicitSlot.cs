using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogElicitSlot : IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Dialog.ElicitSlot";

        [JsonPropertyName("slotToElicit")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string SlotName { get; set; }

        [JsonPropertyName("updatedIntent")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Intent UpdatedIntent { get; set; }

        public DialogElicitSlot(string slotName)
        {
            SlotName = slotName;
        }

        internal DialogElicitSlot()
        {
        }
    }
}