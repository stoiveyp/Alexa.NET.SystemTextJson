using System;
using System.Collections.Generic;
using System.Linq;


namespace Alexa.NET.Response.Directive
{
    public static class ConnectionSendRequestFactory
    {
        public static List<IConnectionSendRequestHandler> Handlers = new()
        {
            new AskForPermissionDirectiveHandler()
        };


        public static Type Create(Utf8JsonReader data)
        {
            foreach (var handler in Handlers)
            {
                var temp = data;
                var result = handler.Create(temp);
                if (result != null)
                {
                    return result;
                }
            }

            throw new InvalidOperationException("Unable to parse Connections.SendRequest directive");
        }
    }
}
