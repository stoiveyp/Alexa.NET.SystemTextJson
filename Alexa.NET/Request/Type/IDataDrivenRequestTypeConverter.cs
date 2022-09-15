

namespace Alexa.NET.Request.Type
{
    public interface IDataDrivenRequestTypeConverter : IRequestTypeConverter
    {
        Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options);
    }
}