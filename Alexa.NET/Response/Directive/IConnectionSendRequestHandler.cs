using System;

namespace Alexa.NET.Response.Directive
{
    public interface IConnectionSendRequestHandler
    {
        Type Create(Utf8JsonReader reader);
    }
}