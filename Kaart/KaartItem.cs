namespace Week1Project;

public abstract class KaartItem : Tekenbaar 
{
    private Coordinaat _locatie {get; set;}
    public Kaart Kaart;

    public KaartItem(Kaart kaart, Coordinaat _locatie)
    {
        if (_locatie.x < 0 || _locatie.y < 0)
        {
            throw new Exception("Kan geen item plaatsen in het negatieve!");
        }
        this._locatie = _locatie;
        this.Kaart=kaart;
    }

    public void TekenConsole(ConsoleTekener tekener)
    {
        tekener.SchrijfOp(_locatie, " " + Karakter);
    }

    public Coordinaat Locatie{get;set;}
    public abstract char Karakter{get;}

}