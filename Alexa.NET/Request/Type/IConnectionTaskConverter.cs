using Alexa.NET.ConnectionTasks;

using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.Request.Type
{
    public interface IConnectionTaskConverter
    {
        System.Type IdentifyType(Utf8JsonReader reader);
    }
}
