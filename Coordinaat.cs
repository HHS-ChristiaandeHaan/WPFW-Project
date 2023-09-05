public struct Coordinaat
{
    public readonly int x;
    public readonly int y;

    public Coordinaat (int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Coordinaat operator+ (Coordinaat coordinaat1, Coordinaat coordinaat2)
    {
        // Coordinaat newCoordinaat = new Coordinaat{x = (coordinaat1.x + coordinaat2.x), y = (coordinaat1.y + coordinaat2.y)};
        // return newCoordinaat;
        return new Coordinaat(coordinaat1.x + coordinaat2.x, coordinaat1.y + coordinaat2.y);
    }

    public static Coordinaat operator- (Coordinaat coordinaat1, Coordinaat coordinaat2)
    {
        // Coordinaat newCoordinaat = new Coordinaat{x = (coordinaat1.x - coordinaat2.x), y = (coordinaat1.y - coordinaat2.y)};
        // return newCoordinaat;
        return new Coordinaat(coordinaat1.x + coordinaat2.x, coordinaat1.y + coordinaat2.y);

    }
}