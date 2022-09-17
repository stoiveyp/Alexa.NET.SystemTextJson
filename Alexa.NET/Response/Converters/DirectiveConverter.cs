
using System;
using System.Collections.Generic;
using Alexa.NET.Response.Directive;
using Alexa.NET.SystemTextJson;


namespace Alexa.NET.Response.Converters
{
    public class DirectiveConverter : JsonConverter<IDirective>
    {
        public static Dictionary<string, Type> TypeFactories = new()
        {
            { "AudioPlayer.Play", typeof(AudioPlayerPlayDirective) },
            { "AudioPlayer.ClearQueue", typeof(ClearQueueDirective) },
            { "Dialog.ConfirmIntent", typeof(DialogConfirmIntent) },
            { "Dialog.ConfirmSlot", typeof(DialogConfirmSlot) },
            { "Dialog.Delegate", typeof(DialogDelegate) },
            { "Dialog.ElicitSlot", typeof(DialogElicitSlot) },
            { "AudioPlayer.Stop", typeof(StopDirective) },
            { "VideoApp.Launch", typeof(VideoAppDirective) },
            { "Connections.StartConnection", typeof(StartConnectionDirective) },
            { "Tasks.CompleteTask",typeof(CompleteTaskDirective)},
            { "Dialog.UpdateDynamicEntities", typeof(DialogUpdateDynamicEntities) }
        };

        public delegate Type DataDrivenTypeCheck(Utf8JsonReader reader);

        public static Dictionary<string, DataDrivenTypeCheck> DataDrivenTypeFactory =
            new()
            {
                {"Connections.SendRequest", ConnectionSendRequestFactory.Create}
            };

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IDirective);
        }

        public override IDirective Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var typeValue = JsonUtility.GetPropertyValue(reader, "type");

            var hasTypeFactory = TypeFactories.ContainsKey(typeValue);
            var dataTypeFactory = DataDrivenTypeFactory.ContainsKey(typeValue);

            Type directive;

            if (hasTypeFactory)
            {
                directive = TypeFactories[typeValue];
            }
            else if (dataTypeFactory)
            {
                directive = DataDrivenTypeFactory[typeValue](reader);
            }
            else
            {
                var json = JsonSerializer.Deserialize<JsonDirective>(ref reader, options);
                json.Type = typeValue;
                return json;
            }

            return (IDirective)this.ReadWithoutConverter(ref reader, directive, options);
        }

        public override void Write(Utf8JsonWriter writer, IDirective value, JsonSerializerOptions options)
        {
            writer.WriteWithoutConverter(this, value, options);
        }
    }
}