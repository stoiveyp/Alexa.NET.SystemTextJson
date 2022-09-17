

namespace Alexa.NET.Request
{
    public class Resolution
    {
        [JsonPropertyName("resolutionsPerAuthority")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public ResolutionAuthority[] Authorities { get; set; }
    }
}
