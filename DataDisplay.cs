using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;

namespace TheAdventurerGuild
{
    class DataDisplay
    {
       
        public static void WriteData(string dialogue)
        {
            if (dialogue.Contains("{charName}") == true)
            {
                string fixedString = dialogue.Replace("{charName}", GameState.CharName);
                Console.WriteLine(fixedString);
            }
            else
            {
                Console.WriteLine(dialogue);
            }
            
        }
        
    }
}