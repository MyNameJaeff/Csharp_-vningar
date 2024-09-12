namespace DagarMellanDatum
{
    internal class Program
    {
        static int GetDaysAmount(DateTime date1, DateTime date2)
        {
            // Calculates the diffrence between the two dates
            TimeSpan difference = date1 - date2;

            // Returns the absolute value of the amount of days between the two dates
            return Math.Abs(difference.Days);
        }
        static void Main(string[] args)
        {
            DateTime date1 = Convert.ToDateTime("2004-12-07");
            DateTime date2 = DateTime.Today;

            int daysBetween = GetDaysAmount(date1, date2);
            Console.WriteLine($"Antalet dagar mellan {date1.ToShortDateString()} och {date2.ToShortDateString()} är {daysBetween} dagar.");
        }
    }
}
