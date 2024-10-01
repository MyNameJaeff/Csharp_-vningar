using System;

namespace TheOOPHotelPart2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public Person() { }

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");
        }
    }
}