﻿
using System;
using System.Collections.Generic;
using Alexa.NET.Response.Directive;


namespace Alexa.NET.Response.Converters
{
    public class DirectiveConverter : JsonConverter
    {
        public override bool CanRead => true;

        public override bool CanWrite => false;

        public static Dictionary<string, Func<IDirective>> TypeFactories = new()
        {
            { "AudioPlayer.Play", () => new AudioPlayerPlayDirective() },
            { "AudioPlayer.ClearQueue", () => new ClearQueueDirective() },
            { "Dialog.ConfirmIntent", () => new DialogConfirmIntent() },
            { "Dialog.ConfirmSlot", () => new DialogConfirmSlot() },
            { "Dialog.Delegate", () => new DialogDelegate() },
            { "Dialog.ElicitSlot", () => new DialogElicitSlot() },
            { "Display.RenderTemplate", () => new DisplayRenderTemplateDirective() },
            { "Hint", () => new HintDirective() },
            { "AudioPlayer.Stop", () => new StopDirective() },
            { "VideoApp.Launch", () => new VideoAppDirective() },
            { "Connections.StartConnection", () => new StartConnectionDirective() },
            { "Tasks.CompleteTask",() => new CompleteTaskDirective()},
            { "Dialog.UpdateDynamicEntities", () => new DialogUpdateDynamicEntities() }
        };

        public static Dictionary<string, Func<JObject, IDirective>> DataDrivenTypeFactory =
            new()
            {
                {"Connections.SendRequest", ConnectionSendRequestFactory.Create}
            };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var typeKey = jsonObject["type"] ?? jsonObject["Type"];
            var typeValue = typeKey.Value<string>();
            var hasTypeFactory = TypeFactories.ContainsKey(typeValue);
            var dataTypeFactory = DataDrivenTypeFactory.ContainsKey(typeValue);

            IDirective directive;

            if (hasTypeFactory)
            {
                directive = TypeFactories[typeValue]();
            }
            else if(dataTypeFactory)
            {
                directive = DataDrivenTypeFactory[typeValue](jsonObject);
            }
            else
            {
                directive = new JsonDirective(typeValue);
            }

            serializer.Populate(jsonObject.CreateReader(), directive);

            return directive;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IDirective);
        }
    }
}