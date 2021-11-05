using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace VirtualPets.Utilities
{
    public class SaveUtil
    {
        /// <summary>
        /// Takes in VirtualPet, serializes the object data and saves to text file.
        /// </summary>
        /// <param name="pet"></param>
        public static void SaveGame(VirtualPet pet)
        {
            string serializedJson = JsonConvert.SerializeObject(pet);
            var docPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "savedGame.json")))
            {
                 outputFile.WriteAsync(serializedJson);
            }
        }

    }
}
