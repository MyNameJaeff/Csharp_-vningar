// Användaren matar in gästnamn
using TheOOPHotel;

Console.Write("Enter guest name: ");
string guestName = Console.ReadLine();

// Användaren matar in startdatum
Console.Write("Enter start date (yyyy-mm-dd): ");
DateTime startDate = Convert.ToDateTime(Console.ReadLine());

// Användaren matar in antal dagar för vistelsen
Console.Write("Enter length of stay in days: ");
string lenghtOfStayInDays = Console.ReadLine();

// Användaren matar in priset per natt
Console.Write("Write price per night: ");
int pricePerNight = Convert.ToInt32(Console.ReadLine());

// Skapa en ny bokning
HotelBooking booking = new HotelBooking(guestName, startDate, Convert.ToInt32(lenghtOfStayInDays), pricePerNight);

// Skriv ut ursprunglig bokningsinformation
Console.WriteLine("Original booking information:");
booking.DisplayBookingInfo(); //Ska även visa priset för vistelsen nu

// Användaren matar in nytt antal dagar för att ändra bokningen
Console.Write("Enter new length of stay in days: ");
string newLenghtOfStayInDays = Console.ReadLine();

// Ändra längden på vistelsen
booking.UpdateLengthOfStay(Convert.ToInt32(newLenghtOfStayInDays));

// Skriv ut uppdaterad bokningsinformation
Console.WriteLine("\nUpdated booking information:");
booking.DisplayBookingInfo();