using System.IO;
using Json.More;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Alexa.NET.Tests
{
    public static class Utility
    {
        private const string ExamplesPath = "Examples";

        public static bool CompareJson(object actual, string expectedFile)
        {
            var actualJObject = JsonSerializer.SerializeToDocument(actual);
            var expectedJObject = JsonDocument.Parse(File.OpenRead(FilePath(expectedFile)));
            return actualJObject.IsEquivalentTo(expectedJObject);
        }
        
        public static T ExampleFileContent<T>(string expectedFile)
        {
            return JsonSerializer.Deserialize<T>(File.OpenRead(FilePath(expectedFile)));
        }

        private static string FilePath(string expectedFile) => Path.Combine(ExamplesPath, expectedFile);
    }
}