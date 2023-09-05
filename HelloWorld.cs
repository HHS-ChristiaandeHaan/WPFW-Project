// See https://aka.ms/new-console-template for more information 
//dotnet new console --use-program-main -lang "C#" -n "Week1Project" 
//zie dotnet new console -h voor informatie
//use-program-main om top level statements te verkomen.

using System.Text;
using Week1Project;
using Authenticatie;

class HelloWorld
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!\n");
        // BoterKaasEieren boterKaasEieren = new BoterKaasEieren();
        // boterKaasEieren.Speler();
        // boterKaasEieren.PrintVeld();
        // boterKaasEieren.Spel();

        // Kaart k = new Kaart(30, 30);
        // Pad p1 = new Pad();
        // p1.van = new Coordinaat(2, 5);
        // p1.van = new Coordinaat(12, 30);
        // k.VoegPadToe(p1);
        // Pad p2 = new Pad
        // {
        //     van = new Coordinaat(26, 4),
        //     naar = new Coordinaat(10, 5)
        // };
        // k.VoegPadToe(p2);
        // k.VoegItemToe(new Attractie(k, new Coordinaat(15, 15)));
        // k.VoegItemToe(new Attractie(k, new Coordinaat(20, 15)));
        // k.VoegItemToe(new Attractie(k, new Coordinaat(5, 18)));
        // k.Teken(new ConsoleTekener());
        // new ConsoleTekener().SchrijfOp(new Coordinaat(0, k.Hoogte + 1), "Deze kaart is schaal 1:1000");
        // System.Console.Read();

        Console.WriteLine("Maak een nieuw gebruiker aan.");
        System.Console.WriteLine("Voer een email in:");
        string email = Console.ReadLine();

        System.Console.WriteLine("Voer een wachtwoord in:");
        string wachtwoord = Console.ReadLine();

        EmailService emailService = new EmailService();
        GebruikerContext gebruikerContext = new GebruikerContext();

        GebruikerService gebruikerService = new GebruikerService(emailService,gebruikerContext);
        gebruikerService.Registreer(email,wachtwoord);

        System.Console.WriteLine("Voer uw token in: ");
        string token = Console.ReadLine();
        System.Console.WriteLine(token);

        gebruikerService.Verifieer(email, wachtwoord,token);
        gebruikerService.Login(email,wachtwoord);

    }
}
