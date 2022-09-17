using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.Request.Type
{
    public class LocationServices
    {
        [JsonPropertyName("access")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<LocationServiceAccess>))]
        public LocationServiceAccess Access { get; set; }

        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverterEx<LocationServiceStatus>))]
        public LocationServiceStatus Status { get; set; }
    }
}
