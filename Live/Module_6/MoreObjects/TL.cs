namespace MoreObjects;

// TL erft nu van Lamp.
// Je mag maar van 1 class erven!
// Overerving bevordert hergebruik.
public class TL : Lamp
{
    public int StarterInterval { get; set; }

    public void Starter()
    {
        for (int i = 0; i < StarterInterval; i++)
        {
            Console.BackgroundColor = Kleur;

            Console.WriteLine("Knipperdeknipper");
            Task.Delay(100).Wait();
            Console.ResetColor();
            Console.Clear();
            Task.Delay(100).Wait();
        }
        Console.ResetColor();
    }
    // Met override activeer ik polymorfisme
    public override void Aan()
    {
        //base.Aan();
        Starter();
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL is aan en brandt met een intensiteit van {Intensiteit}lm");
        Console.ResetColor();
    }
}
