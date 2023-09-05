using System.Runtime.Intrinsics.X86;

namespace Week1Project;
class BoterKaasEieren
{
    public char[,] data = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
    public string speler1;
    public string speler2;

    public void PrintVeld()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write(data[i, j] + "\t");
            }
            Console.WriteLine("X" + i);
        }
        for (int i = 0; i < data.GetLength(1); i++)
        {
            Console.Write("Y" + i + "\t");
        }
        //data[0, 1] = '2';
    }

    public void Speler()
    {
        Console.WriteLine("Enter naam van speler 1 :");
        speler1 = Console.ReadLine();

        Console.WriteLine("Enter naam van speler 2 :");
        speler2 = Console.ReadLine();

    }

    public void Spel()
    {
        bool Spel = true;
        while (Spel)
        {
            Zet('X');
            PrintVeld();
        }
    }
    public void Zet(char keuze)
    {
        bool _zet = true;
        while (_zet)
        {
            Console.Write("\nVoer een x/row zet in : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nVoer een y/col zet in : \n");   
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                data[x,y] = keuze;
                _zet = false;
            }
            catch (System.Exception)
            {
                Zet(keuze);
                //throw;
            }
        }
    }
}