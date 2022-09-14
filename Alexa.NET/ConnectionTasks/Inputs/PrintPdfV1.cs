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

        [JsonPropertyName("context")]
        public ConnectionTaskContext Context { get; set; }

        [JsonPropertyName("@version")]
        public string Version => 1.ToString();

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

    }
}
