using System.Collections.Generic;


namespace Alexa.NET.Response.Directive
{
    public class AudioItemSources
    {
		[JsonPropertyName("sources")]
		public List<AudioItemSource> Sources { get; set; } = new();
    }
}