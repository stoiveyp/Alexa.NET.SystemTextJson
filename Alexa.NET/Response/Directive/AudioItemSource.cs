using System;


namespace Alexa.NET.Response.Directive
{
	public class AudioItemSource
	{
		public AudioItemSource()
		{
		}

		public AudioItemSource(string url)
		{
			Url = url;
		}

		[JsonPropertyName("url")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
		public string Url { get; set; }
    }
}
