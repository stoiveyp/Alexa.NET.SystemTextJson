using System.Collections.Generic;


namespace Alexa.NET.Response.Directive
{
    public class AudioItemSources
    {
		[JsonPropertyName("sources")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public List<AudioItemSource> Sources { get; set; } = new();
    }
}