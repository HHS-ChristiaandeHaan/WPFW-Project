namespace Authenticatie;

class EmailService : IEmailService
{
    public bool Email (string tekst, string naarAdres)
    {
        Console.WriteLine(tekst + "\n Verstuurd naar: " + naarAdres);
        return true;
    }
}
