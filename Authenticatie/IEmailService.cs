namespace Authenticatie;

interface IEmailService
{
    public bool Email (string tekst, string naarAdres);
}