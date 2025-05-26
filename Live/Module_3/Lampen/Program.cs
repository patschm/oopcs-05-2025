namespace Lampen;

internal class Program
{
    static void Main(string[] args)
    {
        Lamp l1 = new Lamp();
        l1.Kleur = ConsoleColor.Yellow;
        //l1._intensiteit = 4_000_000_000;
        // l1.SetIntesiteit(-200);
        l1.Intensiteit = 250;
        l1.Aan();

        Lamp l2 = new Lamp();
        l2.Aan();

        Lamp l3 = new Lamp(400, ConsoleColor.DarkCyan);
        l3.Aan();

        Lamp l4 = new Lamp { Kleur = ConsoleColor.DarkCyan, Intensiteit=300 };
        //l4.SetIntesiteit(300);
        l4.Aan();
    }
}

// Blauwdruk lamp
class Lamp
{
    // Eigenschappen sla je op in fields.
    private int _intensiteit = 200;
    //private ConsoleColor _kleur = ConsoleColor.Black;
    private GloeiDraad _gloeiend = new GloeiDraad { spanning = 100 };


    // C+++-ish
    public void SetIntesiteit(int intensiteit)
    {
        if (intensiteit > 0 && intensiteit < 2000)
        {
            _intensiteit = intensiteit;
        }
    }
    public int GetIntensiteit()
    {
        return _intensiteit;
    }

    // Property. Om gecontroleerde toegang tot de fields te regelen
    public int Intensiteit
    {
        set
        {
            if (value > 0 && value < 2000)
            {
                _intensiteit = value;
            }
        }
        get
        {
            return _intensiteit;
        }
    }

    // Auto generating properties. Genereren hun eigen field
    public ConsoleColor Kleur { set;  get; } = ConsoleColor.DarkYellow;

    // Gedrag leg je vast in Methods (functions of procedures)
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is aan en brandt met een intensiteit van {_intensiteit}lm");
        Console.ResetColor();
    }

    // De constructors. Zijn bedoeld om fields een initiele waarde te geven
    public Lamp() : this(200, ConsoleColor.Red)
    {
        //intensiteit = 200;
        //kleur = ConsoleColor.Red;
    }
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        Intensiteit = intensiteit;
        Kleur = kleur;
    }
}


