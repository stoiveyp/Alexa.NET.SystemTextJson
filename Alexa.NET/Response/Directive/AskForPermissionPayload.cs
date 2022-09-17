﻿

namespace Alexa.NET.Response.Directive
{
    public class AskForPermissionPayload
    {
        public AskForPermissionPayload()
        {

        }

        public AskForPermissionPayload(string permissionScope)
        {
            PermissionScope = permissionScope;
        }

        [JsonPropertyName("@type")] 
        public string Type { get; set; } = "AskForPermissionsConsentRequest";

        [JsonPropertyName("@version")] 
        public string Version { get; set; } = "1";

        [JsonPropertyName("permissionScope")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PermissionScope { get; set; }
    }
}