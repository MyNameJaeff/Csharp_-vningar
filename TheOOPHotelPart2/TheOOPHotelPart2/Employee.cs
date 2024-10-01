using System;

namespace TheOOPHotelPart2
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public ShiftPreferences ShiftPreference { get; set; }
        public int VacationDays { get; set; }
        public decimal PerformanceRating { get; set; }

        public Employee() { }

        public Employee(string name, int age, string employeeId, DateTime startDate, decimal salary, string phone, string email, string address, string jobTitle, string department, ShiftPreferences shiftPreference, int vacationDays, decimal performanceRating)
            : base(name, age, employeeId, startDate, salary, phone, email, address)
        {
            JobTitle = jobTitle;
            Department = department;
            ShiftPreference = shiftPreference;
            VacationDays = vacationDays;
            PerformanceRating = performanceRating;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name}, som jobbar som {JobTitle} på avdelningen {Department}, utför sitt arbete.");
        }

        public override void DoWork()
        {
            Console.WriteLine($"The employee {Name} is completing their tasks as a {JobTitle}.");
        }

        public void RequestVacation(int days)
        {
            if (days <= VacationDays)
            {
                Console.WriteLine($"{Name} har beviljats {days} dagars semester.");
                VacationDays -= days;
            }
            else
            {
                Console.WriteLine($"{Name} har inte tillräckligt med semesterdagar för att beviljas {days} dagars semester.");
            }
        }

        public void ChangeShift(ShiftPreferences newShift)
        {
            ShiftPreference = newShift;  // Update the shift for the instance
            Console.WriteLine($"{Name} har bytt skift till {newShift}.");
        }
    }
}
