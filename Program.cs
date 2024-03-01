using System;

class Program
{
    static void Main(string[] args)
    {
        Passport passport = new Passport
        {
            FullName = "John Doe",
            Nationality = "USA",
            DateOfBirth = new DateTime(1980, 5, 15),
            PlaceOfBirth = "New York",
            PassportNumber = "US123456"
        };

        ForeignPassport foreignPassport = new ForeignPassport
        {
            FullName = "John Doe",
            Nationality = "USA",
            DateOfBirth = new DateTime(1980, 5, 15),
            PlaceOfBirth = "New York",
            PassportNumber = "US123456",
            VisaInformation = "Schengen Visa",
            PassportNumberAbroad = "ABCD1234"
        };

        Console.WriteLine("Passport Information:");
        passport.DisplayInfo();

        Console.WriteLine();

        Console.WriteLine("Foreign Passport Information:");
        foreignPassport.DisplayInfo();
    }
}
