using System.Collections.Generic;


namespace Alexa.NET.Request
{
    public class Intent
    {
        private string _name;

        [JsonPropertyName("name")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Name {
            get { return _name; }
            set {
                _name = value;
                Signature = value;
            }
        }

        [JsonIgnore]
        public IntentSignature Signature { get; private set; }


        [JsonPropertyName("confirmationStatus")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ConfirmationStatus { get; set; }

        [JsonPropertyName("slots")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, Slot> Slots { get; set; }
    }
}