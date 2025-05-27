namespace MoreObjects;

internal class Program
{
    static void Main(string[] args)
    {

        //Lamp lmp0 = new Lamp { Intensiteit = 300, Kleur = ConsoleColor.DarkGreen };
        
        // Generaliseren!
        Lamp lmp1 = new TL { Intensiteit = 200, Kleur = ConsoleColor.Green, StarterInterval = 5 };
        ((TL)lmp1).StarterInterval = 10;
        (lmp1 as TL)!.StarterInterval = 7;

        //lmp1.Aan();
        SteekAan(lmp1);


        //lmp0.Aan();
        //SteekAan(lmp0);

        Led lmp2 = new Led {Intensiteit = 400, Kleur= ConsoleColor.Red };
        SteekAan(lmp2);    
        //lmp2.Aan();      
    }

    static void SteekAan(Lamp t)
    {
        t.Aan();
    }
    
}
