
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request
{
    public class Device
    {
        [JsonPropertyName("deviceId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string DeviceID { get; set; }

        [JsonPropertyName("supportedInterfaces")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object> SupportedInterfaces { get; set; }

        public bool IsInterfaceSupported(string interfaceName)
        {
            var hasInterface = SupportedInterfaces?.ContainsKey(interfaceName);
            return (hasInterface.HasValue ? hasInterface.Value : false); 
        }

        [JsonPropertyName("persistentEndpointId")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PersistentEndpointID { get; set; }
    }
}
