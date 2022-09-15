

using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Request.Type
{
    //https://developer.amazon.com/en-US/docs/alexa/smapi/voice-permissions-for-reminders.html#send-a-connectionssendrequest-directive
    public class AskForRequestHandler : IConnectionResponseHandler
    {
        public bool CanCreate(Utf8JsonReader reader)
        {
            if (ReaderUtility.ScanObjectForType(ref reader, "name"))
            {
                return ReaderUtility.ReadPropertyValue(ref reader) == "AskFor";
            }

            return false;
        }

        public ConnectionResponseRequest Create(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<AskForPermissionRequest>(ref reader, options);
        }
    }
}