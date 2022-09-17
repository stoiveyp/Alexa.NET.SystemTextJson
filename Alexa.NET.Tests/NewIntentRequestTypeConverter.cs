using Alexa.NET.Request.Type;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Alexa.NET.Tests
{
    public class NewIntentRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "AlexaNet.CustomIntent";
        }

        public Request.Type.Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<NewIntentRequest>(ref reader, options);
        }
    }
}