namespace Authenticatie;

interface IGebruikersContext
{
    public int AantalGebruikers();
    public Gebruiker NieuweGebruiker(string wachtwoord, string email);
    public Gebruiker GetGebruiker(string email, string wachtwoord);
    public Gebruiker GetGebruiker(int i);

}