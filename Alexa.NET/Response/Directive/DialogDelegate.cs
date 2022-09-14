using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogDelegate:IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.Delegate";

        [JsonPropertyName("updatedIntent")]
        public Intent UpdatedIntent { get; set; }
    }
}
