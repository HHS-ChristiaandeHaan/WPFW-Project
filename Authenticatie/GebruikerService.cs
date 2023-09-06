namespace Authenticatie;

class GebruikerService 
{
    public IEmailService emailService;
    public IGebruikersContext gebruikerContext;
    
    public GebruikerService(IEmailService emailService, IGebruikersContext gebruikerContext)
    {
        this.emailService = emailService;
        this.gebruikerContext = gebruikerContext;
    }

    public void Registreer (string email, string wachtwoord)
    {   
        Gebruiker _gebruiker = gebruikerContext.NieuweGebruiker(email,  wachtwoord);
        emailService.Email("Er is een email verstuurd naar: " + _gebruiker.Email + 
        "\n Gebruik de code: "+ _gebruiker.VerificatieToken.token + " om te verifieeren" , _gebruiker.Email);
    }

    public bool Login (string email, string wachtwoord)
    {
        Gebruiker gebruiker = gebruikerContext.GetGebruiker(email ,wachtwoord);
        if (gebruiker != null)
        {
            if (gebruiker.Geverifieerd())
            {
                System.Console.WriteLine("Ingelogt");
                return true;

            }
            return true;
            
        }
        System.Console.WriteLine("Niet ingelogt");
        return false;
    }

    public bool Verifieer (string email, string wachtwoord, string token)
    {   
        Gebruiker gebruiker = gebruikerContext.GetGebruiker(email ,wachtwoord);
        if (gebruiker != null)
        {
            if (gebruiker.VerificatieToken.token == token && DateTime.Compare(DateTime.Today, gebruiker.VerificatieToken.verloopDatum) <= 0)
            {
                gebruiker.VerificatieToken = null;
                System.Console.WriteLine("Verifieerd");
                return true;
            }
            System.Console.WriteLine("Niet Verifieerd");
            return false;
        }
        System.Console.WriteLine("Gebruiker niet gevonden");
        return false;
    }


}