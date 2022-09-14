

namespace Alexa.NET.Request.Type
{
    public class GeolocationHeading
    {
        [JsonPropertyName("directionInDegrees")]
        public double? Direction { get; set; }
        [JsonPropertyName("accuracyInDegrees")]
        public double? Accuracy { get; set; }
    }
}