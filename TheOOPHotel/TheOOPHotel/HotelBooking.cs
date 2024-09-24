namespace TheOOPHotel;

public class HotelBooking
{
    public string GuestName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LengthOfStayInDays { get; set; }
    public int PricePerNight { get; set; }

    public HotelBooking(string name, DateTime startDate, int lengthOfStayInDays, int pricePerNight)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Guest name cannot be empty.");

        if (startDate < DateTime.Today)
            throw new ArgumentException("Start date cannot be in the past.");

        if (lengthOfStayInDays <= 0)
            throw new ArgumentException("Length of stay must be greater than zero.");

        if (pricePerNight <= 0)
            throw new ArgumentException("Price per night must be greater than zero.");
        
        GuestName = name;
        StartDate = startDate;
        LengthOfStayInDays = lengthOfStayInDays;
        EndDate = startDate.AddDays(lengthOfStayInDays);
        PricePerNight = pricePerNight;
    }

    public void DisplayBookingInfo()
    {
        Console.WriteLine($"Name: {GuestName}, StartDate: {StartDate}," +
                          $" LengthOfStayInDays: {LengthOfStayInDays}," +
                          $" EndDate: {EndDate}, PricePerNight: {PricePerNight}");
    }

    public void UpdateLengthOfStay(int numberOfDaysToAdd)
    {
        if (numberOfDaysToAdd <= 0)
            throw new ArgumentException("Number of days to add must be greater than zero.");

        LengthOfStayInDays += numberOfDaysToAdd;
        EndDate = EndDate.AddDays(numberOfDaysToAdd);
    }

    public int CalculatePrice()
    {
        return (LengthOfStayInDays * PricePerNight);
    }
}