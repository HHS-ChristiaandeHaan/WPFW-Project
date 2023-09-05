namespace Authenticatie;

class GebruikerService 
{
    public IEmailService emailService;
    
    public GebruikerService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public Gebruiker Registreer (string email, string wachtwoord)
    {
        return new Gebruiker{Email = email, Wachtwoord = wachtwoord};
    }

    public bool Login (string email, string wachtwoord)
    {
        return false;
    }

    public bool Verifieer (string email, string token)
    {
        return false;
    }


}