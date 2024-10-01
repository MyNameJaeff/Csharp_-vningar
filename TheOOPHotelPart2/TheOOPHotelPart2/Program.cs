using System;

namespace TheOOPHotelPart2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> hotelStaff = new List<Person>();
            hotelStaff.Add(new Manager { Name = "Maria Svensson", Age = 45, EmployeeId = "M002", Department = "Operations", Salary = 55000m, StartDate = new DateTime(2018, 5, 1) });
            hotelStaff.Add(new Employee { Name = "Johan Andersson", Age = 28, EmployeeId = "E002", JobTitle = "Receptionist", Department = "Front Desk", Salary = 32000m, StartDate = new DateTime(2021, 9, 15) });
            hotelStaff.Add(new Consultant { Name = "Sara Lindberg", Age = 38, EmployeeId = "C002", ConsultingFirm = "Hotell Konsulterna AB", HourlyRate = 1200m, StartDate = new DateTime(2023, 3, 1) });
            hotelStaff.Add(new Employee { Name = "Kalle Persson", Age = 33, EmployeeId = "E003", JobTitle = "Kock", Department = "Kök", Salary = 35000m, StartDate = new DateTime(2020, 11, 1) });
            hotelStaff.Add(new Manager { Name = "Eva Karlsson", Age = 50, EmployeeId = "M003", Department = "HR", Salary = 58000m, StartDate = new DateTime(2015, 2, 1) });
            Console.WriteLine("Hotellets personal:");
            foreach (var person in hotelStaff)
            {
                person.PrintInfo();
                person.Introduce();
    
                if (person is Manager manager)
                {
                    manager.HoldMeeting();
                }
                else if (person is Employee employee)
                {
                    employee.Work();
                }
                else if (person is Consultant consultant)
                {
                    consultant.GiveAdvice();
                }
    
                Console.WriteLine(); // Lägg till en tom rad för läsbarhet
            }
            
            double averageAge = hotelStaff.Average(p => p.Age);
            decimal totalSalary = hotelStaff.Sum(p => p.Salary);

            Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");
            Console.WriteLine($"Total månadslön för anställda: {totalSalary:C}");
        }
    }
}