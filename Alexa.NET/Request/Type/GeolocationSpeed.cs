

namespace Alexa.NET.Request.Type
{
    public class GeolocationSpeed
    {
        [JsonPropertyName("speedInMetersPerSecond")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double? Speed { get; set; }
        [JsonPropertyName("accuracyInMetresPerSecond")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public double? Accuracy { get; set; }
    }
}