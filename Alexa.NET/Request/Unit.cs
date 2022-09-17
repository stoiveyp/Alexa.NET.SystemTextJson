

namespace Alexa.NET.Request
{
    public class Unit
    {
        [JsonPropertyName("unitId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string UnitID { get; set; }

        [JsonPropertyName("persistentUnitId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PersistentUnitID { get; set; }
    }
}