using System;

namespace TheOOPHotelPart2
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }

        public Employee() { }

        public Employee(string name, int age, string employeeId, DateTime startDate, decimal salary, string jobTitle, string department)
            : base(name, age, employeeId, startDate, salary)
        {
            JobTitle = jobTitle;
            Department = department;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name}, som jobbar som {JobTitle} på avdelningen {Department}, utför sitt arbete.");
        }
    }
}