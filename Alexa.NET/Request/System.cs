
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request
{
    public class AlexaSystem
    {
        [JsonPropertyName("apiAccessToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ApiAccessToken { get; set; }

        [JsonPropertyName("apiEndpoint")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string ApiEndpoint { get; set; }

        [JsonPropertyName("application")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Application Application { get; set; }

        [JsonPropertyName("person")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Person Person { get; set; }

        [JsonPropertyName("user")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public User User { get; set; }

        [JsonPropertyName("device")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Device Device { get; set; }

        [JsonPropertyName("unit")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Unit Unit { get; set; }
    }
}
