using System;
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class AskForPermissionsConsentCard : ICard
    {

        [JsonPropertyName("type")]
        
        public string Type
        {
            get { return "AskForPermissionsConsent"; }
        }

        [JsonPropertyName("permissions")]
        
        public List<string> Permissions { get; set; } = new();
    }
}
