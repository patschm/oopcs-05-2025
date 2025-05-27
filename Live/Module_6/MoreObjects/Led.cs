using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreObjects;

internal class Led : Lamp
{
    public override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De LED-lamp brand met {Intensiteit}lm");
        Console.ResetColor();
    }
}
