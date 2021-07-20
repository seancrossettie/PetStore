using System;
using PetStore.Pets;

namespace PetStore
{
    class Program
    {
        // static means shared across all instances
        static void Main(string[] args)
        {
            var ginger = new Dogs("Ginger", 45, "Medium");
            ginger.Bark();
            ginger.Eat("table scraps");
        }
    }
}
