using System;

namespace TheOOPHotelPart2
{
    public class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }
        public Consultant() {}
        public Consultant(string name, int age, string employeeId, DateTime startDate, decimal hourlyRate, string consultingFirm, string expertise)
            : base(name, age, employeeId, startDate, 0) 
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner, då den är en expert på {Expertise}.");
        }
    }
}