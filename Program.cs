using System;
using PetStore.Pets;

namespace PetStore
{
    class Program
    {
        // static means shared across all instances
        static void Main(string[] args)
        {
            var ginger = new Dogs();
            ginger.Name = "Ginger";
            ginger.Size = "Medium";
            ginger.Weight = 45;
            ginger.Bark();
            ginger.Eat("table scraps");
        }
    }
}
