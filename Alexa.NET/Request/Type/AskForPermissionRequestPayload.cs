using Alexa.NET.SystemTextJson;
using System;
using System.Runtime.Serialization;



namespace Alexa.NET.Request.Type
{
    public class AskForPermissionRequestPayload
    {
        [JsonPropertyName("permissionScope")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string PermissionScope { get; set; }

        [JsonPropertyName("status"), JsonConverter(typeof(JsonStringEnumConverterEx<PermissionStatus>))]
        public PermissionStatus Status { get; set; }
    }

    public enum PermissionStatus
    {
        [EnumMember(Value = "ACCEPTED")]
        Accepted,
        [EnumMember(Value = "DENIED")]
        Denied,
        [EnumMember(Value = "NOT_ANSWERED")]
        NotAccepted
    }
}