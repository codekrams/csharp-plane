using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Flugzeug
    {
        //Klassenvariablen
        private int max_gewicht; 
        private int tankinhalt=0;
        private int sitzplaetze;
        private int max_geschwindigkeit;
        private int akt_geschwindigkeit = 0;
        private string flugzeug_name="";

        //neuer Konstruktor
        public Flugzeug(int mg, string fn) {
            max_geschwindigkeit = mg;
            flugzeug_name = fn;
        }

        //Methoden
        public void tacho() {
            Console.WriteLine(flugzeug_name + ": Aktuelle Geschwindigkeit: " + akt_geschwindigkeit.ToString());
        }

        public void tanken(int liter)
        {
            tankinhalt += liter;
        }

        public void tankinhalt_anzeigen() {
            Console.WriteLine(flugzeug_name + ": Aktueller Tankinhalt: " + tankinhalt.ToString());
        }

        public void beschleunigen(int km) {

            akt_geschwindigkeit += km;

            if (akt_geschwindigkeit > max_geschwindigkeit) {
                akt_geschwindigkeit = max_geschwindigkeit;
            }
        }

        public void bremsen(int km)
        {

            akt_geschwindigkeit -= km;

            if (akt_geschwindigkeit < 0)
            {
                akt_geschwindigkeit = 0;
            }
        }


    }
}

