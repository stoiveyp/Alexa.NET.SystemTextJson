

namespace Alexa.NET.Request.Type
{
    public class GeolocationCoordinate
    {
        [JsonPropertyName("latitudeInDegrees")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double Latitude { get; set; }

        [JsonPropertyName("longitudeInDegrees")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double Longitude { get; set; }

        [JsonPropertyName("accuracyInMeters")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double Accuracy { get; set; }
    }
}