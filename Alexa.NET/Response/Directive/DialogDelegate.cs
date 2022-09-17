using System;
using Alexa.NET.Request;


namespace Alexa.NET.Response.Directive
{
    public class DialogDelegate:IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Dialog.Delegate";

        [JsonPropertyName("updatedIntent")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Intent UpdatedIntent { get; set; }
    }
}
