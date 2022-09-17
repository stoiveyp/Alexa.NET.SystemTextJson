using System;
using System.Linq;
using Alexa.NET.Request.Type;
using Alexa.NET.Response.Converters;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PinConfirmationConverter : IConnectionTaskConverter
    {
        public IConnectionTask Convert(JsonDocument jObject)
        {
            return jObject.Deserialize<PinConfirmation>();
        }

        public static void AddToConnectionTaskConverters()
        {
            if (ConnectionTaskConverter.ConnectionTaskConverters.Where(rc => rc != null)
                .All(rc => rc.GetType() != typeof(PinConfirmationConverter)))
            {
                ConnectionTaskConverter.ConnectionTaskConverters.Add(new PinConfirmationConverter());
            }
        }

        public static PinConfirmationResult ResultFromSessionResumed(SessionResumedRequest request)
        {
            if (request.Cause.Result is JsonElement jo)
            {
                return jo.Deserialize<PinConfirmationResult>();
            }

            return null;
        }

        public Type IdentifyType(Utf8JsonReader reader)
        {
            var value = JsonUtility.GetPropertyValue(ref reader, "uri");
            if (value == PinConfirmation.AssociatedUri)
            {
                return typeof(PinConfirmation);
            }

            return null;
        }
    }
}