using System;

namespace TheOOPHotelPart2
{
    public class Manager : Person
    {
        public string Department { get; set; }
        public Manager() { }
        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department)
            : base(name, age, employeeId, startDate, salary)
        {
            Department = department;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name}, chefen för {Department}, håller ett personalmöte.");
        }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name}, chefen hållet på att planera budgeten för hotellet.");
        }
    }
}