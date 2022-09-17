using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Helpers;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class ScheduleTaxiReservation:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.ScheduleTaxiReservation/1";
        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("@type")]
        public string Type => "ScheduleTaxiReservationRequest";

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("context")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("partySize")]
        public int PartySize { get; set; }

        [JsonPropertyName("pickupLocation")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress PickupLocation { get; set; }

        [JsonPropertyName("dropoffLocation")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress DropoffLocation { get; set; }

        [JsonPropertyName("pickupTime"),JsonConverter(typeof(MixedDateTimeConverter))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? PickupTime { get; set; }
    }
}
