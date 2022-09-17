﻿

namespace Alexa.NET.Request.Type
{
    public class GeolocationAltitude
    {
        [JsonPropertyName("altitudeInMeters")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double? Altitude { get; set; }

        [JsonPropertyName("accuracyInMeters")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double? Accuracy { get; set; }
    }
}