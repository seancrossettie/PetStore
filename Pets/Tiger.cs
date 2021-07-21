using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Tiger
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }

        public Tiger(string name, string size, int numberOfKills, short speed)
        {
            Name = name;
            Size = size;
            NumberOfKills = numberOfKills;
            Speed = speed;
        }

        private int _numberOfBites;

        public void Bite(string handlerName)
        {
            _numberOfBites++;
            Console.WriteLine($"{Name} the tiger just ate {handlerName} :)"); 
        }
    }
}
