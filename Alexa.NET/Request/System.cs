
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request
{
    public class AlexaSystem
    {
        [JsonPropertyName("apiAccessToken")]
        public string ApiAccessToken { get; set; }

        [JsonPropertyName("apiEndpoint")]
        public string ApiEndpoint { get; set; }

        [JsonPropertyName("application")]
        public Application Application { get; set; }

        [JsonPropertyName("person")]
        public Person Person { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("device")]
        public Device Device { get; set; }

        [JsonPropertyName("unit")]
        public Unit Unit { get; set; }
    }
}
