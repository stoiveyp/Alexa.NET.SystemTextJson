namespace Alexa.NET.Request.Type
{
    public class AudioPlayerRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType.StartsWith("AudioPlayer");
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<AudioPlayerRequest>(ref reader, options);
        }
    }
}