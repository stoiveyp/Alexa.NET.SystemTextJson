using System;
using Alexa.NET.ConnectionTasks;


namespace Alexa.NET.Response.Directive
{
    public class StartConnectionDirective:IDirective
    {
        [JsonPropertyName("type")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Type => "Connections.StartConnection";

        [JsonPropertyName("uri")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Uri { get; set; }

        [JsonPropertyName("input")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public IConnectionTask Input { get; set; }

        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }

        [JsonPropertyName("onComplete")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(JsonStringEnumConverterEx<OnCompleteAction>))]
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
