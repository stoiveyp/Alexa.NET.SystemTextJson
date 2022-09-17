using System;
using System.Collections.Generic;
using System.Text;


namespace Alexa.NET.ConnectionTasks.Inputs
{
    public class PostalAddress
    {
        [JsonPropertyName("@type")] public string Type => "PostalAddress";
        [JsonPropertyName("@version")] public string Version => 1.ToString();
        [JsonPropertyName("streetAddress")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string StreetAddress { get; set; }
        [JsonPropertyName("locality")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string Locality { get; set; }
        [JsonPropertyName("region")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string Region { get; set; }
        [JsonPropertyName("postalCode")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string PostalCode { get; set; }
        [JsonPropertyName("country")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string Country { get; set; }
    }
}
