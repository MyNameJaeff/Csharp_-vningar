namespace TheOOPHotel;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Person(string name, string email, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Guest name cannot be empty.");
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty.");
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("PhoneNumber cannot be empty.");

        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}