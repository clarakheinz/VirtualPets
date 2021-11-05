using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VirtualPets.Utilities
{
    public class LoadUtil
    {
        /// <summary>
        /// Reads savedGame file and deserializes Json to instantiate VirtualPet object
        /// </summary>
        /// <returns></returns>
        public static Object LoadGame()
        {
            var docPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            JObject json = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Path.Combine(docPath, "savedGame.json")));
            var preferredtype = json["PetType"].ToString();

            object pet;
            if (preferredtype == "VirtualPets.Dog")
            {
                pet = json.ToObject<Dog>();
            }
            else if (preferredtype == "VirtualPets.Cat")
            {
                pet = json.ToObject<Cat>();

            }
            else
            {
                throw new InvalidOperationException("There was an issue loading your pet. Please start a new game by selecting 'Create New Pet'.\n");
            }

            return pet;
        }
    }
}
