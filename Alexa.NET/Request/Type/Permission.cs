

namespace Alexa.NET.Request.Type
{
    public class Permission
    {
        [JsonPropertyName("scope")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Scope { get; set; }
    }
}