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
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary, string phone, string email, string address)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");
        }

        public virtual void DoWork()
        {
            Console.WriteLine($"{Name} does some working");
        }

        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
        }

        public void CalculateYearsOfService()
        {
            int years = DateTime.Now.Year - StartDate.Year;
            Console.WriteLine($"{Name} har jobbat på hotellet i {years} år.");
        }

        public void ChangeEmployeeId(string newId)
        {
            EmployeeId = newId;
        }

        public void UpdateContactInfo(string phone, string email, string address)
        {
            Phone = phone;
            Email = email;
            Address = address;
        }
    }
}
