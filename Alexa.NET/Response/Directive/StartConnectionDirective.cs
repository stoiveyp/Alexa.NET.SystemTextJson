using System;
using Alexa.NET.ConnectionTasks;



namespace Alexa.NET.Response.Directive
{
    public class StartConnectionDirective:IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Connections.StartConnection";

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("input")]
        public IConnectionTask Input { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("onComplete")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OnCompleteAction? OnComplete { get; set; }

        public StartConnectionDirective(){}

        public StartConnectionDirective(IConnectionTask input, string token)
        {
            this.Uri = input.ConnectionUri;
            this.Input = input;
            this.Token = token;
        }
    }
}
