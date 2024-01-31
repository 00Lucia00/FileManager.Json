using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDictionaryTests
{
    internal class ExtraMethods
    {
        /// <summary>
        /// Serializes a dictionary to a JSON string.
        /// </summary>
        /// <param name="dict">The dictionary to serialize.</param>
        /// <returns>A JSON string representing the dictionary.</returns>
        public string CreateJsonFromDictionary(Dictionary<string, object> dict)
        {
            return JsonConvert.SerializeObject(dict);
        }

        /// <summary>
        /// Deserializes a JSON string to a dictionary.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A dictionary representing the JSON data, or null if deserialization fails.</returns>
        public Dictionary<string, object>? CreateDictionaryFromJson(string json)
        {
            Dictionary<string, object>? dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            return dict;
        }

        /// <summary>
        /// Writes a JSON string to a file named 'data.json' in the current directory.
        /// </summary>
        /// <param name="json">The JSON string to write to the file.</param>
        public void WriteJsonFile(string json)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data.json");

            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Reads a JSON string from a file named 'data.json' in the current directory.
        /// </summary>
        /// <returns>The JSON string read from the file.</returns>
        public string ReadJsonFile()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data.json");

            string json = File.ReadAllText(filePath);

            return json;
        }
    }
}

