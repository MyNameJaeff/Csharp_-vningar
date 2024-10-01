using System;

namespace TheOOPHotelPart2
{
    public class Manager : Person
    {
        public string Department { get; set; }
        public int TeamSize { get; set; }
        public decimal BonusPercentage { get; set; }
        public LevelsOfManagement ManagementLevel { get; set; }

        public Manager() { }

        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string phone, string email, string address, string department, int teamSize, decimal bonusPercentage, LevelsOfManagement managementLevel)
            : base(name, age, employeeId, startDate, salary, phone, email, address)
        {
            Department = department;
            TeamSize = teamSize;
            BonusPercentage = bonusPercentage;
            ManagementLevel = managementLevel;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name}, chefen för {Department}, håller ett personalmöte.");
        }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name}, chefen håller på att planera budgeten för hotellet.");
        }

        public void AssignTeam(int size)
        {
            TeamSize = size;
            Console.WriteLine($"{Name} har tilldelat ett team med storlek {TeamSize}.");
        }

        public decimal CalculateBonus()
        {
            decimal bonus = Salary * (BonusPercentage / 100);
            Console.WriteLine($"{Name} har en beräknad bonus på {bonus:C}.");
            return bonus;
        }

        public override void DoWork()
        {
            Console.WriteLine($"The manager {Name} is planning and leading in the {Department} department.");
        }
    }
}
