using System;



namespace Alexa.NET.Helpers
{
	public class MixedDateTimeConverter : JsonConverter<DateTime>
    {
		static readonly DateTime UnixEpoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private DateTime UtcFromEpoch(long epochTime)
		{
			return UnixEpoch.AddMilliseconds(epochTime);
		}

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TryGetDateTime(out var dt))
            {
                return dt;
            }

            if (reader.TokenType == JsonTokenType.Number)
            {
                return UtcFromEpoch(reader.GetInt64());
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                return DateTime.Parse(reader.GetString());
            }

            return UtcFromEpoch(long.Parse(reader.GetString()));
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
