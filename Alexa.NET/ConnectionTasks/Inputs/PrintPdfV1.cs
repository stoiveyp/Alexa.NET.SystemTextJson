using System;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PrintPdfV1:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.PrintPDF/1";

        [JsonIgnore]
        public string ConnectionUri => AssociatedUri;

        [JsonPropertyName("@type")]
        public string Type => "PrintPDFRequest";

        [JsonPropertyName("context")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("title")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Title { get; set; }

        [JsonPropertyName("description")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Description { get; set; }

        [JsonPropertyName("url")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Url { get; set; }

    }
}
