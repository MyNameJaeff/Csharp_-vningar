using TheOOPHotel;
using System;

class Program
{
    static void Main()
    {
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Ange ditt namn: ");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Namnet kan inte vara tomt. Försök igen.");
            }
        }

        string email = "";
        while (string.IsNullOrWhiteSpace(email))
        {
            Console.Write("Ange din e-post: ");
            email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("E-post kan inte vara tomt. Försök igen.");
            }
        }

        string phone = "";
        while (string.IsNullOrWhiteSpace(phone))
        {
            Console.Write("Ange ditt telefonnummer: ");
            phone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Telefonnummer kan inte vara tomt. Försök igen.");
            }
        }

        Person guest = new Person(name, email, phone);

        DateTime startDate;
        while (true)
        {
            Console.Write("Ange startdatum (åååå-mm-dd): ");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out startDate))
            {
                if (startDate < DateTime.Today)
                {
                    Console.WriteLine("Startdatum kan inte vara i det förflutna. Försök igen.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt datumformat. Vänligen använd åååå-mm-dd.");
            }
        }

        int lengthOfStay;
        while (true)
        {
            Console.Write("Ange vistelsens längd i dagar: ");
            if (int.TryParse(Console.ReadLine(), out lengthOfStay) && lengthOfStay > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Längden på vistelsen måste vara ett giltigt positivt tal. Försök igen.");
            }
        }

        int pricePerNight;
        while (true)
        {
            Console.Write("Ange pris per natt: ");
            if (int.TryParse(Console.ReadLine(), out pricePerNight) && pricePerNight > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Pris per natt måste vara ett giltigt positivt tal. Försök igen.");
            }
        }

        HotelBooking booking = new HotelBooking(guest, startDate, lengthOfStay, pricePerNight);

        Console.WriteLine("Ursprunglig bokningsinformation:");
        booking.DisplayBookingInfo();

        int newLengthOfStay;
        while (true)
        {
            Console.Write("Ange nytt antal dagar för vistelsen: ");
            if (int.TryParse(Console.ReadLine(), out newLengthOfStay) && newLengthOfStay > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Nytt antal dagar måste vara ett giltigt positivt tal. Försök igen.");
            }
        }

        booking.UpdateLengthOfStay(newLengthOfStay);

        Console.WriteLine("\nUppdaterad bokningsinformation:");
        booking.DisplayBookingInfo();
    }
}
