

using System;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Response.Directive
{
    public class AskForPermissionDirectiveHandler : IConnectionSendRequestHandler
    {
        public Type Create(Utf8JsonReader reader)
        {
            if (JsonUtility.GetPropertyValue(reader, "name") == "AskFor")
            {
                return typeof(AskForPermissionDirective);
            }

            return null;
        }
    }
}