using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Klassen
    {
        

        static void Main(string[] args)
        {
            Flugzeug[] Flugzeugflotte = new Flugzeug[2];
            Flugzeugflotte[0] = new Flugzeug(300, "Flugzeug Marilyn");
            Flugzeugflotte[1] = new Flugzeug(300, "Flugzeug Nautilus");

            Flugzeug f;
            int eingabe=0;

            do
            {
                
                int auswahl = auswahlFlugzeug();
                f = Flugzeugflotte[auswahl-1];
              
                eingabe = menueAuswahl();
                aktivitetsAuswahl(eingabe, f);

                Console.WriteLine("Drücken Sie 1 zum Weiterspielen oder 0 zum Beenden");
                eingabe = Convert.ToInt32(Console.ReadLine());

            } while (eingabe != 0);

            Console.WriteLine("Auf Wiedersehen");
            Console.ReadKey();
        }



        private static int auswahlFlugzeug() {
            int auswahl;
            Console.WriteLine("Welcher Flieger soll es sein? 1 oder 2");
            auswahl = Convert.ToInt32(Console.ReadLine());
            return auswahl;
        }

        private static int menueAuswahl() {
            Console.WriteLine("Menü:");
            Console.WriteLine("1 Geschwindigkeit anzeigen");
            Console.WriteLine("2 Beschleunigen");
            Console.WriteLine("3 Bremsen");
            Console.WriteLine("4 Tanken");
            Console.WriteLine("5 Alles anzeigen");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            return eingabe;
        }


        private static void aktivitetsAuswahl(int eingabe, Flugzeug f) {
            int beschl;
            int brems;
            int tank;

            if (eingabe == 1)
            {
                f.tacho();
            }
            else if (eingabe == 2)
            {
                Console.WriteLine("Wie schnell soll beschleunigt werden?");
                beschl = Convert.ToInt32(Console.ReadLine());
                f.beschleunigen(beschl);
                f.tacho();
            }
            else if (eingabe == 3)
            {
                Console.WriteLine("Wie stark soll gebremst werden?");
                brems = Convert.ToInt32(Console.ReadLine());
                f.bremsen(brems);
                f.tacho();

            }
            else if (eingabe == 4)
            {
                Console.WriteLine("Wie viel soll getankt werden?");
                tank = Convert.ToInt32(Console.ReadLine());
                f.tanken(tank);
                f.tankinhalt_anzeigen();
            }
            else if (eingabe == 5)
            {
                
                f.tankinhalt_anzeigen();
                f.tacho();
            }
            else if (eingabe > 5)
            {
                Console.WriteLine("Ungültige Eingabe");
            }

        }

    }
}
