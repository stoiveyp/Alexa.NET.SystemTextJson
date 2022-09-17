using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.SystemTextJson;

namespace Alexa.NET.Response;

public class EmptyListConverter<T>:JsonConverter<IList<T>>
{
    public override IList<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return new List<T>();
        }
        return this.ReadWithoutConverter<IList<T>>(ref reader,  options);
    }

    public override void Write(Utf8JsonWriter writer, IList<T> value, JsonSerializerOptions options)
    {
        if (!value.Any())
        {
            writer.WriteNullValue();
            return;
        }

        writer.WriteWithoutConverter(this, value, options);
    }
}