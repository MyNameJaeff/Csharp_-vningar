using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilÖvning
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Milage { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }

        public Car(string make, string model, string color,int year, double milage, string fuelType)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Milage = milage;
            FuelType = fuelType;
        }

        public void Drive(double kilometer)
        {
            Milage += kilometer / 10; // Delat med tio för kilometer till mil
        }

        public void CheckService()
        {
            Console.WriteLine((Milage >= 2000) ? "Bilen behöver åka in på service!" : "Bilen behöver inte service än!"); // Ifall över 2000 mil skriv service annars inte
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Color: {Color},Year: {Year}, Milage: {Milage}, FuelType: {FuelType}"); // Printar all info
        }
    }
}
