using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogElicitSlot : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.ElicitSlot";

        [JsonPropertyName("slotToElicit")]
        public string SlotName { get; set; }

        [JsonPropertyName("updatedIntent")]
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