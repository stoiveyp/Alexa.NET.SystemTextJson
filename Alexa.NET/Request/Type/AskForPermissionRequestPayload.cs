using System;
using System.Runtime.Serialization;



namespace Alexa.NET.Request.Type
{
    public class AskForPermissionRequestPayload
    {
        [JsonPropertyName("permissionScope")]
        public string PermissionScope { get; set; }

        [JsonPropertyName("status"), JsonConverter(typeof(JsonStringEnumConverter))]
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