namespace ageCalculator
{
    class Program
    {
        static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;

            // Check if the birthday has not occurred yet this year
            if (DateTime.Today < birthDate.AddYears(age))
            {
                age--;
            }

            Console.WriteLine(age);
            return age;
        }

        static void Main(string[] args)
        {
            CalculateAge(DateTime.Parse("2004-12-07"));
        }
    }

}
