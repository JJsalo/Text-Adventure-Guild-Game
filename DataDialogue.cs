using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace TheAdventurerGuild
{
    class DataDialogue
    {
        public static string RetrieveData(string jsonFile, string keyValue)                                                //Retrieving Json files and converting to string
        {
            try
            {
                string fileName = jsonFile + ".json";
                Dictionary<string, string> dialogue = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(fileName));   //Read the Json file and create string
                string value = dialogue[keyValue];
                return value;

            } 
            catch (Exception ex)
            {
                Console.WriteLine("Shits fucked up");
                return "Error";
            }
            
            
        }
    }
}