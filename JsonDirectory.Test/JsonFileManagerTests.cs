using FluentAssertions;
using JsonDictionaryTests;
using Newtonsoft.Json;

namespace JsonDirectoryTests.Test
{
    public class JsonFileManagerTests
    {
        
            // Har en dictionary, f�r JSON tillbaka
            [Fact]
            public void CreateJsonFromDict_ShouldReturnJson()
            {
                // Given
                Dictionary<string, object> dict = new()
                {
                    { "Name", "Gandalf" },
                    { "Age", 3000 },
                    { "Profession", "Wizard" }
                };
                JsonFileManager manager = new();

                // When
                string expectedJson = JsonConvert.SerializeObject(dict);
                string returnedJson = manager.CreateJsonFromDict(dict);

                // Then
                returnedJson.Should().NotBeNull();
                returnedJson.Should().BeEquivalentTo(expectedJson);
            }

            [Fact]
            public void CreateJsonFromDict_EmptyDict_ShouldThrowArgumentException()
            {
                // Given
                Dictionary<string, object> dict = new();
                JsonFileManager manager = new();

                // When
                Action test = () => manager.CreateJsonFromDict(dict);

                // Then
                test.Should().Throw<ArgumentException>();
            }

            [Fact]
            public void CreateJsonFromDict_NullDict_ShouldThrowArgumentNullException()
            {
                // Given
                Dictionary<string, object>? dict = null;
                JsonFileManager manager = new();

                // When
                Action test = () => manager.CreateJsonFromDict(dict);

                // Then
                test.Should().Throw<ArgumentNullException>();
            }

            [Fact]
            public void CreateJsonFromDict_NullValue_ShouldThrowNullReferenceException()
            {
                // Given
                Dictionary<string, object> dict = new()
                {
                     { "Name", "Gandalf" },
                     { "Age", null },
                     { "Profession", "Wizard" }
                };
                JsonFileManager manager = new();

                // When
                Action test = () => manager.CreateJsonFromDict(dict);

                // Then
                test.Should().Throw<NullReferenceException>();
            }

            [Fact]
            public void WriteJsonFile_ValidJson_ShouldWriteJsonFile()
            {
                // Given
                object obj = new { Name = "Sam Gamgee", Age = 30, Profession = "Gardener" };
                string json = JsonConvert.SerializeObject(obj);
                string fileName = "test.json";
                JsonFileManager manager = new();

                // When
                manager.WriteJsonFile(json, fileName);

                // Then
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                string fileContent = File.ReadAllText(filePath);
                fileContent.Should().BeEquivalentTo(json);
            }

            // Testa f�ljande:
            // WriteJsonFile
            // Invalid JSON
            // Utfall: Throws JsonReaderException
            [Fact]
            public void WriteJsonFile_InvalidJson_ShouldThrowJsonReaderException()
            {
                // Given
                string invalidJson = "This is invalid JSON";
                string fileName = "test.json";
                JsonFileManager manager = new();

                // When
                Action test = () => manager.WriteJsonFile(invalidJson, fileName);

                // Then
                test.Should().Throw<JsonReaderException>();
            }
       
    }
    
}