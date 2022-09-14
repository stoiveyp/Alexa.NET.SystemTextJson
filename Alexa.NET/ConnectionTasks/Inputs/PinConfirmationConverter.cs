using System;
using System.Linq;
using Alexa.NET.Request.Type;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PinConfirmationConverter : IConnectionTaskConverter
    {
        public bool CanConvert(JObject jObject)
        {
            return jObject.ContainsKey("uri") &&
                   jObject.GetValue("uri").Value<string>() == PinConfirmation.AssociatedUri;
        }

        public IConnectionTask Convert(JObject jObject)
        {
            var task = new PinConfirmation();
            Serializer.Populate(jObject.CreateReader(), task);
            return task;
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
            if (request.Cause.Result is JObject jo)
            {
                var task = new PinConfirmationResult();
                Serializer.Populate(jo.CreateReader(), task);
                return task;
            }

            return null;
        }
    }
}