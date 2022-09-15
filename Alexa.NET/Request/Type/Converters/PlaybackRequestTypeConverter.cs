namespace Alexa.NET.Request.Type
{
    public class PlaybackRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType.StartsWith("PlaybackController");
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<PlaybackControllerRequest>(ref reader, options);
        }
    }
}