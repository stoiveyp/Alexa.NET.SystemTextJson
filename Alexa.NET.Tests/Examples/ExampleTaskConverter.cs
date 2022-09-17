using System;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Request.Type;
using Alexa.NET.Response.Converters;

using System.Linq;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Tests.Examples
{
    public class ExampleTaskConverter : IConnectionTaskConverter
    {
        public static void AddToConnectionTaskConverters()
        {
            if (ConnectionTaskConverter.ConnectionTaskConverters.Where(rc => rc != null)
                .All(rc => rc.GetType() != typeof(ExampleTaskConverter)))
            {
                ConnectionTaskConverter.ConnectionTaskConverters.Add(new ExampleTaskConverter());
            }
        }

        public Type IdentifyType(Utf8JsonReader reader)
        {
            if (JsonUtility.ScanObjectForType(ref reader, "randomParameter"))
            {
                return typeof(ExampleTask);
            }

            return null;
        }
    }
}
