using System;
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class AskForPermissionsConsentCard : ICard
    {

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public string Type
        {
            get { return "AskForPermissionsConsent"; }
        }

        [JsonPropertyName("permissions")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        
        public List<string> Permissions { get; set; } = new();
    }
}
