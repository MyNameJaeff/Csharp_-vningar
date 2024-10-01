using System;
using System.Collections.Generic;

namespace TheOOPHotelPart2
{
    public class Housekeeper : Employee
    {
        public CleaningSpeeds CleaningSpeed { get; set; }
        public List<string> SpecialtyAreas { get; set; }
        public Dictionary<string, int> SuppliesInventory { get; set; }

        public Housekeeper()
        {
            SpecialtyAreas = new List<string>();
            SuppliesInventory = new Dictionary<string, int>();
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotellrummen.");
        }

        public override void DoWork()
        {
            Console.WriteLine($"The housekeeper {Name} is cleaning the hotel rooms.");
        }

        public void AddSpecialtyArea(string area)
        {
            SpecialtyAreas.Add(area);
            Console.WriteLine($"{Name} har lagt till specialområdet: {area}.");
        }

        public void UpdateSuppliesInventory(string item, int quantity)
        {
            if (SuppliesInventory.ContainsKey(item))
            {
                SuppliesInventory[item] += quantity;
            }
            else
            {
                SuppliesInventory[item] = quantity;
            }
            Console.WriteLine($"{quantity} units of {item} added to {Name}'s supplies inventory.");
        }
    }
}
