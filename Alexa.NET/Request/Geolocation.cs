using System;
using Alexa.NET.Request.Type;


namespace Alexa.NET.Request
{
    public class Geolocation
    {
        [JsonPropertyName("locationServices")]
        public LocationServices LocationServices { get; set; }
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [JsonPropertyName("coordinate")]
        public GeolocationCoordinate Coordinate { get; set; }
        [JsonPropertyName("altitude")]
        public GeolocationAltitude Altitude { get; set; }
        [JsonPropertyName("heading")]
        public GeolocationHeading Heading { get; set; }
        [JsonPropertyName("speed")]
        public GeolocationSpeed Speed { get; set; }
    }
}