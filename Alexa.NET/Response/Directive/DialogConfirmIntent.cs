using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogConfirmIntent : IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Dialog.ConfirmIntent";

        [JsonPropertyName("updatedIntent")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Intent UpdatedIntent { get; set; }
    }
}
