using System;
using System.Collections.Generic;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.ConnectionTasks.Inputs;
using Alexa.NET.Request.Type;
using Alexa.NET.SystemTextJson;


namespace Alexa.NET.Response.Converters
{
    public class ConnectionTaskConverter : JsonConverter<IConnectionTask>
    {
        public static Dictionary<string, Type> TaskFactoryFromUri = new()
        {
            {"PrintPDFRequest/1",typeof(PrintPdfV1) },
            {"PrintImageRequest/1", typeof(PrintImageV1) },
            {"PrintWebPageRequest/1",typeof(PrintWebPageV1)},
            {"ScheduleTaxiReservationRequest/1",typeof(ScheduleTaxiReservation) },
            {"ScheduleFoodEstablishmentReservationRequest/1",typeof(ScheduleFoodEstablishmentReservation)}
        };

        public static readonly List<IConnectionTaskConverter> ConnectionTaskConverters = new();


        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IConnectionTask);
        }

        public override IConnectionTask Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var typeKey = JsonUtility.GetPropertyValue(reader, "@type");
            var versionKey = JsonUtility.GetPropertyValue(reader, "@version");
            var factoryKey = $"{typeKey}/{versionKey}";
            var hasFactory = TaskFactoryFromUri.ContainsKey(factoryKey);
            if (hasFactory)
            {
                var directive = TaskFactoryFromUri[factoryKey];
                return (IConnectionTask)this.ReadWithoutConverter(ref reader, directive, options);
            }

            foreach (var converter in ConnectionTaskConverters)
            {
                var tempReader = reader;
                var converterType = converter.IdentifyType(tempReader);
                if (converterType != null)
                {
                    return (IConnectionTask)this.ReadWithoutConverter(ref reader, converterType, options);
                }
            }

            throw new Exception(
                $"unable to deserialize response. " +
                $"unrecognized task type '{typeKey}' with version '{versionKey}'"
            );
        }

        public override void Write(Utf8JsonWriter writer, IConnectionTask value, JsonSerializerOptions options)
        {
            writer.WriteWithoutConverter(this, value, options);
        }
    }
}