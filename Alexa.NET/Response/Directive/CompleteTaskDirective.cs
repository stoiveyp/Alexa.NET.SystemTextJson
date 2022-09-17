using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.ConnectionTasks;


namespace Alexa.NET.Response.Directive
{
    public class CompleteTaskDirective:IDirective
    {
        public CompleteTaskDirective() { }

        public CompleteTaskDirective(int statusCode, string statusMessage)
        {
            Status = new ConnectionStatus(statusCode,statusMessage);
        }

        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Tasks.CompleteTask";

        [JsonPropertyName("status")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionStatus Status { get; set; } 
    }
}
