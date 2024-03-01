using System;

public class ForeignPassport : Passport, IVisa
{
    public string VisaInformation { get; set; }
    public string PassportNumberAbroad { get; set; }

    public void DisplayVisaInfo()
    {
        Console.WriteLine($"Visa Information: {VisaInformation}");
        Console.WriteLine($"Passport Number Abroad: {PassportNumberAbroad}");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        DisplayVisaInfo();
    }
}

public interface IVisa
{
    string VisaInformation { get; set; }
    string PassportNumberAbroad { get; set; }

    void DisplayVisaInfo();
}
