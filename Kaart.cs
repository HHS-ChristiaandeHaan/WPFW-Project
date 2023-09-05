using System.IO.Compression;

namespace Week1Project;

public class Kaart
{
    public readonly int Breedte;
    //readonly is hetzelfde als {get;} zonder set;
    public readonly int Hoogte;

    public List<KaartItem> kaartItems;
    public List<Pad> paden;
    public Kaart(int breedte, int hoogte)
    {
        this.Breedte = breedte;
        this.Hoogte = hoogte;
        kaartItems = new List<KaartItem>();
        paden = new List<Pad>();
    }

    public void Teken(Tekener tekener)
    {
        TekenLijst(tekener,this.paden);
        TekenLijst(tekener,this.kaartItems);
    }

    public void TekenLijst <T>(Tekener tekener, List<T> tekenbaars) where T: Tekenbaar
    {
        foreach (var tekenbaar in tekenbaars)
        {
            tekener.teken(tekenbaar);
        }
    }

    public void VoegItemToe(KaartItem item)
    {
        kaartItems.Add(item);
    }
    public void VoegPadToe(Pad pad)
    {
        paden.Add(pad);
    }
}
