namespace Alexa.NET.Request.Type
{
    public class TemplateEventRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Display.ElementSelected";
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<DisplayElementSelectedRequest>(ref reader, options);
        }
    }
}