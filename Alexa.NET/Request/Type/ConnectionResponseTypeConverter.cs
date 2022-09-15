using System;
using System.Collections.Generic;
using System.Linq;


namespace Alexa.NET.Request.Type
{
    public class ConnectionResponseTypeConverter : IDataDrivenRequestTypeConverter
    {
        public static List<IConnectionResponseHandler> Handlers = new()
        {
            new AskForRequestHandler()
        };

        public bool CanConvert(string requestType)
        {
            return requestType == "Connections.Response";
        }

        public Request Convert(string requestType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            foreach (var h in Handlers)
            {
                var temp = reader;
                if (h.CanCreate(temp))
                {
                    return h.Create(ref reader, options);
                }
            }

            return ;
        }
    }
}