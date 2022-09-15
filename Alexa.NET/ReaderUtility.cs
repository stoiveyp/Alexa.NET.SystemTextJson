using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.SystemTextJson
{
    public static class ReaderUtility
    {
        public static string GetPropertyValue(ref Utf8JsonReader dReader, string propertyName)
        {
            if (!ScanObjectForType(ref dReader, propertyName))
            {
                throw new InvalidOperationException($"Unable to find {propertyName} discriminator");
            }

            return ReadPropertyValue(ref dReader);
        }

        public static string ReadPropertyValue(ref Utf8JsonReader dReader)
        {
            dReader.Read();
            return (dReader.TokenType == JsonTokenType.Number)
                ? dReader.GetInt32().ToString()
                : dReader.GetString();
        }

        public static bool ScanObjectForType(ref Utf8JsonReader dReader, string propertyName, bool skip = false)
        {
            while (skip || dReader.TokenType != JsonTokenType.PropertyName || dReader.GetString() != propertyName)
            {
                if (!dReader.Read())
                {
                    return false;
                }

                if (dReader.TokenType == JsonTokenType.StartObject)
                {
                    if (ScanObjectForType(ref dReader, propertyName, true))
                    {
                        return true;
                    }
                }

                else if (dReader.TokenType == JsonTokenType.EndObject)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
