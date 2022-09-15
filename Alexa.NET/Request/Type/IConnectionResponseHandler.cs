

namespace Alexa.NET.Request.Type
{
    public interface IConnectionResponseHandler
    {
        bool CanCreate(Utf8JsonReader reader);
        ConnectionResponseRequest Create(ref Utf8JsonReader reader, JsonSerializerOptions options);
    }
}