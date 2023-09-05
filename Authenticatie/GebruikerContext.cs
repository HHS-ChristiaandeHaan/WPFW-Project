namespace Authenticatie;

class GebruikerContext
{
    private List<Gebruiker> gebruikers = new List<Gebruiker>();


    public Gebruiker GetGebruiker(string email, string wachtwoord)
    {
        if (gebruikers.FindIndex(a => a.Email == email) != -1 && gebruikers.FindIndex(a => a.Wachtwoord == wachtwoord) != -1)
        {
            return GetGebruiker(gebruikers.FindIndex(a => a.Email == email));
        }
        return null;
    }
    public int AantalGebruikers()
    {
        return gebruikers.Count();
    }

    public Gebruiker GetGebruiker(int i)
    {
        return gebruikers[i];
    }

    public Gebruiker NieuweGebruiker(string wachtwoord, string email)
    {
        Gebruiker gebruiker = new Gebruiker{Wachtwoord = wachtwoord, Email = email};
        gebruikers.Add(gebruiker);
        return gebruiker;
    }
}