using System;

public class Passport
{
    public string FullName { get; set; }
    public string Nationality { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Nationality: {Nationality}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Place of Birth: {PlaceOfBirth}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
    }
}
