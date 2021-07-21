using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int NumberOfFishEaten { get; set; }
        public Tiger BestTigerFriend { get; set; }

        // Read-only property
        public bool LovesHoney { get; }
        
        // Setting a variable with a default value
        public string EducationLevel { get; set; } = "GED";

        public Bear(string name, string type)
        {
            Name = name;
            Type = type;

            if (name == "Winnie")
            {
                LovesHoney = true;
            } else if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }

        public Bear(string name, string type, string educationLevel) : this(name, type) => EducationLevel = educationLevel;


        public Bear(string name, string type, string educationLevel, int howManyFish ) : this(name, type, educationLevel)
        {
            NumberOfFishEaten = howManyFish;
        }

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }

        public void HangOut()
        {
            Console.WriteLine($"{Name} the tiger is hanging out with his best friend, {BestTigerFriend.Name}");
        }
    }
}
