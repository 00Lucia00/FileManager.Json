// See https://aka.ms/new-console-template for more information
using JsonDictionaryTests;

Console.WriteLine("Hello, World!");


try
{
    JsonFileManager manager = new();
    Dictionary<string, object> dict = new(); // Create empty dict

    manager.CreateJsonFromDict(dict);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}