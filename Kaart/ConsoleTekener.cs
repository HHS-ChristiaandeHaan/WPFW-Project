namespace Week1Project;

public class ConsoleTekener : Tekener
{
    public void teken(Tekenbaar tekenbaar)
    {
        tekenbaar.TekenConsole(this);
    }

    public void SchrijfOp(Coordinaat Positie, string Text)
    {
        if (Positie.x < 0 || Positie.y < 0)
            throw new Exception("Kan niet tekenen in het negatieve!");
        Console.SetCursorPosition(Positie.x, Positie.y); //Was X en Y. Veranderd naar x en y.
        Console.WriteLine(Text);
    }

    
}