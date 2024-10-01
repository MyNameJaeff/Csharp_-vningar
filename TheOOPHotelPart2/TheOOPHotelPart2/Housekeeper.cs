namespace TheOOPHotelPart2;

public class Housekeeper : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} städar hotellrummen");
    }
}