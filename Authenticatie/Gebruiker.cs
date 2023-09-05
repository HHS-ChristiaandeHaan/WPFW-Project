namespace Authenticatie;
class Gebruiker
{
    public string Wachtwoord {get;set;}
    public string Email {get;set;}
    public VerificatieToken? VerificatieToken {get;set;}

    public Gebruiker()
    {
        this.VerificatieToken = new VerificatieToken();
    }
    public bool Geverifieerd()
    {
        if (VerificatieToken == null)
        {
            return true;
        }
        return false;
    } 
}