using DoomsdayPreppers;
using Heras;
using Infrac;
using Philips;

namespace MijnHuis;

internal class Program
{
    static void Main(string[] args)
    {
        DetectieLus lus = new DetectieLus();
        Hek hek = new Hek();
        Valkuil valkuil = new Valkuil();
        Lamp lamp = new Lamp();

        //lus.Connect(hek);
        //lus.Connect(valkuil);
        //lus.Connect(lamp);

        lus.Detecting += hek.Open;
        lus.Detecting += valkuil.Open;
        lus.Detecting += lamp.Aan;

        lus.Detect();
        //hek.Open(); Niet geaccepteerd.
    }
}