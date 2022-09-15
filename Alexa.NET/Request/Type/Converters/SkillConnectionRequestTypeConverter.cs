using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.Request.Type
{
    public class SkillConnectionRequestTypeConverter:IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "SessionResumedRequest";
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<SessionResumedRequest>(ref reader, options);
        }
    }
}
