using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Helpers;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class ScheduleFoodEstablishmentReservation:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.ScheduleFoodEstablishmentReservation/1";
        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("@type")]
        public string Type => "ScheduleFoodEstablishmentReservationRequest";

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("context")]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("partySize")]
        public int PartySize { get; set; }

        [JsonPropertyName("startTime"),JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("restaurant")]
        public Restaurant Restaurant { get; set; }
    }
}
