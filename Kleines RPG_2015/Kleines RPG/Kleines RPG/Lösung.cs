using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Lösung
    {
        public static void lösung()
        {
            Console.WriteLine("Willkommen in der Lösung.");
            Console.WriteLine("Für welches Gebiet benötigen sie die Lösung?");
            Console.WriteLine("Bitte geben sie '1' '2' oder '3' ein.");
            Console.WriteLine("Um die Lösung zu verlassen geben sie bitte 'Verlassen' ein.");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Die lösungen im ersten Gebiet sind:");
                Console.WriteLine("Links");
                Console.WriteLine("Ja");
                Console.WriteLine("Nein");
                Console.WriteLine("Ja");
                Console.ReadLine();
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadLine();
            }
            else if (Console.ReadLine() == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}