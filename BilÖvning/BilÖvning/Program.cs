namespace BilÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Supra", "White", 1999, 0.0, "Disel");
            car1.DisplayInfo();
            car1.Drive(19999);
            car1.DisplayInfo();
            car1.CheckService();
        }
    }
}
