using System;
using System.Collections.Generic;
using System.Linq;

namespace TheOOPHotelPart2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> hotelStaff = new List<Person>
            {
                new Manager
                {
                    Name = "Maria Svensson", Age = 45, EmployeeId = "M002", Department = "Operations",
                    Salary = 55000m, StartDate = new DateTime(2018, 5, 1), TeamSize = 5, BonusPercentage = 10,
                    ManagementLevel = LevelsOfManagement.Senior
                },
                new Employee
                {
                    Name = "Johan Andersson", Age = 28, EmployeeId = "E002", JobTitle = "Receptionist",
                    Department = "Front Desk", Salary = 32000m, StartDate = new DateTime(2021, 9, 15),
                    ShiftPreference = ShiftPreferences.Morning, VacationDays = 10, PerformanceRating = 4.5m
                },
                new Consultant
                {
                    Name = "Sara Lindberg", Age = 38, EmployeeId = "C002", HourlyRate = 1200m,
                    ConsultingFirm = "Hotell Konsulterna AB", StartDate = new DateTime(2023, 3, 1),
                    Expertise = "Hotel security", ContractDuration = TimeSpan.FromDays(30), ProjectName = "Security Review", BillableHours = 0
                },
                new Employee
                {
                    Name = "Kalle Persson", Age = 33, EmployeeId = "E003", JobTitle = "Kock",
                    Department = "Kök", Salary = 35000m, StartDate = new DateTime(2020, 11, 1),
                    ShiftPreference = ShiftPreferences.Evening, VacationDays = 10, PerformanceRating = 4.0m
                },
                new Manager
                {
                    Name = "Eva Karlsson", Age = 50, EmployeeId = "M003", Department = "HR",
                    Salary = 58000m, StartDate = new DateTime(2015, 2, 1), TeamSize = 5, BonusPercentage = 10,
                    ManagementLevel = LevelsOfManagement.MidLevel
                }
            };

            Steg5(hotelStaff);
            Steg6(hotelStaff);
        }

        static void Steg5(List<Person> staff)
        {
            Console.WriteLine("Hotellets personal:");
            foreach (var person in staff)
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

            double averageAge = staff.Average(p => p.Age);
            decimal totalSalary = staff.Sum(p => p.Salary);

            Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");
            Console.WriteLine($"Total månadslön för anställda: {totalSalary:C}");
        }

        static void Steg6(List<Person> staff)
        {
            // Loopa igenom listan och anropa DoWork() för varje anställd
            foreach (Person person in staff)
            {
                person.DoWork(); // Här demonstreras polymorfism då varje anställd utför sitt specifika arbete
            }
        }
    }
}
