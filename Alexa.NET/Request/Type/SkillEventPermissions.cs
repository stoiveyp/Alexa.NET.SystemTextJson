

namespace Alexa.NET.Request.Type
{
    public class SkillEventPermissions
    {
        [JsonPropertyName("acceptedPermissions")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Permission[] AcceptedPermissions { get; set; }
    }
}