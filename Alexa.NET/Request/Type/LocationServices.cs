using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class LocationServices
    {
        [JsonPropertyName("access")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public LocationServiceAccess Access { get; set; }

        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public LocationServiceStatus Status { get; set; }
    }
}
