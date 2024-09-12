static void Start()
{
    Console.WriteLine("År:");
    int year = Convert.ToInt32(Console.ReadLine());

    int a = year % 19;
    int b = year % 4;
    int c = year % 7;

    int k = year / 100;

    int p = (13 + (8 * k)) / 25;
    int q = k / 4;

    int M; int N;

    if (year >= 1583) // Due to the gregorian calender not existing before 1583 i do a check, and if before set M and N to default values according to the julian calander
    {
        M = (15 - p + k - q) % 30; // Should be the correkt values for M and N, unsure due to there not being a lot of info surrounding the formula
        N = (4 + k - q) % 7;
    }
    else
    {
        M = 15;
        N = 6;
    }

    int d = ((19 * a) + M) % 30;
    int e = ((2 * b) + (4 * c) + (6 * d) + N) % 7;

    if (((d == 28) && (e == 6) && (a > 10)) || (22 + d + e - 31) == 26) // If the date is 26/25 april set the date 1 week earlier, due to the formula
    {
        Console.WriteLine($"Easter is the {22 + d + e - 31 - 7}st of april");
    }
    else if (((22 + d + e) - 31) > 0)
    {
        Console.WriteLine($"Easter is the {22 + d + e - 31}st of april");
    }
    else
    {
        Console.WriteLine($"Easter is the {22 + d + e}st of mars");
    }
    Console.WriteLine("");
    Start();
}
Start();
