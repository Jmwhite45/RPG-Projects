using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using static RPG_character_sheet_randomizer.Vars;

namespace RPG_character_sheet_randomizer
{
    class InOut
    {
        string patch = "1.2.0";

        public static string CharToJson(Character Char)
        {
            return JsonConvert.SerializeObject(Char);
        }


        public static void Save(string FileName)
        {
            Save(CharToJson(getCharacter()), FileName);
        }

        public static void Save(string input, string name)
        {
            string dir = @"../../Saves/" + name + ".json";
            StreamWriter writer = new StreamWriter(dir);
            writer.WriteLine(input);
            writer.Close();
        }

        public static bool alreadyExist(string fileName)
        {
            string file = @"../../Saves/" + fileName + ".json";

            return System.IO.File.Exists(file);
        }

        public static Character getCharacter()
        {
            return Vars.SavedChar;
        }
    }
}
