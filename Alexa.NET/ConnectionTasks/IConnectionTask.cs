﻿using System.Text;
using Alexa.NET.Response.Converters;


namespace Alexa.NET.ConnectionTasks
{
    [JsonConverter(typeof(ConnectionTaskConverter))]
    public interface IConnectionTask
    {
        [JsonIgnore]
        string ConnectionUri { get; }
    }
}
