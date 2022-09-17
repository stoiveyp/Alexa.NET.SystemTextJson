using Alexa.NET.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text;



namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PrintImageV1 : IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.PrintImage/1";
        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("@type")]
        public string Type => "PrintImageRequest";

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("context")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("title")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Title { get; set; }

        [JsonPropertyName("description")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Description { get; set; }

        [JsonPropertyName("imageType"),JsonConverter(typeof(JsonStringEnumConverterEx<PrintImageV1Type>))]
        public PrintImageV1Type ImageV1Type { get; set; }

        [JsonPropertyName("url")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Url { get; set; }
    }

    public enum PrintImageV1Type
    {
        JPG,
        JPEG
    }
}
