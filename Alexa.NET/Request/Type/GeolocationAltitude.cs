

namespace Alexa.NET.Request.Type
{
    public class GeolocationAltitude
    {
        [JsonPropertyName("altitudeInMeters")]
        public double? Altitude { get; set; }

        [JsonPropertyName("accuracyInMeters")]
        public double? Accuracy { get; set; }
    }
}