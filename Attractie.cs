using Week1Project;

public class Attractie : KaartItem
{
    public Attractie(Kaart kaart, Coordinaat _locatie) : base(kaart, _locatie)
    {

    }

    public override char Karakter => 'A';

    // public override char Karakter()
    // {
    //     return 'A';
    // }

}
