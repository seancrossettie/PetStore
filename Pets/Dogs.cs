using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dogs // classes are implicitly internal
    {
        // Access Modifiers:
        // private: only things in this class can use it
        // public: everything that can see the class can access it
        // internal: anything in this project can access it
        // protected: anything that inherits from me can access it

        // Properties: 
        // access modifier - type - name
        // public - string - Size
        public string Size { get; set; }
        public short Weight { get; set; }
        public string Name { get; set; }

        // constructor, constructor method
        public Dogs(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }

        // Method Signature : access modifier, return type, name, parameter
        // void means nothing is returned
        public void Bark()
        {
            Console.WriteLine($"{Name}");
        }

        // parameters are camel cased
        public void Eat(string food)
        {
            if (food == "healthy food")
            {
                Weight -= 1;
            } else if (food.ToLower() == "table scraps")
            {
                Weight += 1;
            }

            Console.WriteLine($"{Name} just ate {food}. {Name} weighs {Weight} lbs.");
        }
    }
}
