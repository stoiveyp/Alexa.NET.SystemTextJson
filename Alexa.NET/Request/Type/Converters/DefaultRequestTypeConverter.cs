namespace Alexa.NET.Request.Type
{
    public class DefaultRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "IntentRequest" || requestType == "LaunchRequest" || requestType == "SessionEndedRequest" || requestType == "System.ExceptionEncountered";
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            switch (requestType)
            {
                case "IntentRequest":
                    return JsonSerializer.Deserialize<IntentRequest>(ref reader, options);
                case "LaunchRequest":
                    return JsonSerializer.Deserialize<LaunchRequest>(ref reader, options);
                case "SessionEndedRequest":
                    return JsonSerializer.Deserialize<SessionEndedRequest>(ref reader, options);
                case "System.ExceptionEncountered":
                    return JsonSerializer.Deserialize<SystemExceptionRequest>(ref reader, options);
            }
            return null;
        }
    }
}
