using DoomsdayPreppers;
using Heras;
using Logitech;
using Yunex;

namespace MijnStraat;

internal class Program
{
    static void Main(string[] args)
    {
        DetectieLus lus = new DetectieLus();
        Valkuil kuil = new Valkuil();
        Camera cam = new();
        Hek hek = new();

        lus.Connect(cam);
        lus.Connect(hek);
        lus.Connect(kuil);

        lus.Detecteer();

        // Deze oplossingen keur ik af!!
        //hek.Open(); 
        //kuil.Open();
    }
}
