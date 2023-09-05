namespace Authenticatie;

class GebruikerService 
{
    public IEmailService emailService;
    public GebruikerContext gebruikerContext;
    
    public GebruikerService(IEmailService emailService, GebruikerContext gebruikerContext)
    {
        this.emailService = emailService;
        this.gebruikerContext = gebruikerContext;
    }

    public void Registreer (string email, string wachtwoord)
    {   
        Gebruiker _gebruiker = gebruikerContext.NieuweGebruiker(email,  wachtwoord);
        emailService.Email
        ("Er is een email verstuurd naar: " + _gebruiker.Email + 
        "\n Gebruik de code: "+ " *not implemented * "+ " om te verifieeren" , _gebruiker.Email);
    }

    public bool Login (string email, string wachtwoord)
    {
        gebruikerContext.
        return false;
    }

    public bool Verifieer (string email, string token)
    {   
        return false;
    }


}