using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogConfirmIntent : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.ConfirmIntent";

        [JsonPropertyName("updatedIntent")]
        public Intent UpdatedIntent { get; set; }
    }
}
