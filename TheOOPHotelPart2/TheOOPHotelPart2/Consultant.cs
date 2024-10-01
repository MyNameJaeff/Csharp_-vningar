using System;

namespace TheOOPHotelPart2
{
    public class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }
        public TimeSpan ContractDuration { get; set; }
        public string ProjectName { get; set; }
        public decimal BillableHours { get; set; }

        public Consultant() { }

        public Consultant(string name, int age, string employeeId, DateTime startDate, decimal salary, string phone, string email, string address, decimal hourlyRate, string consultingFirm, string expertise, TimeSpan contractDuration, string projectName, decimal billableHours)
            : base(name, age, employeeId, startDate, salary, phone, email, address)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
            ContractDuration = contractDuration;
            ProjectName = projectName;
            BillableHours = billableHours;
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner, då den är en expert på {Expertise}.");
        }

        public void ExtendContract(TimeSpan extension)
        {
            ContractDuration += extension;
            Console.WriteLine($"{Name}'s contract has been extended by {extension.TotalDays} days.");
        }

        public void LogBillableHours(decimal hours)
        {
            BillableHours += hours;
            Console.WriteLine($"{hours} billable hours logged by {Name}. Total billable hours: {BillableHours}.");
        }

        public override void DoWork()
        {
            Console.WriteLine($"The consultant {Name} is offering strategic advice on {Expertise}.");
        }
    }
}
