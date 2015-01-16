using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Tod
    {
        static public void KeinLeben()
        {
            Console.WriteLine("Dein Leben ist kleiner oder gleich 0.");
            Console.WriteLine("Neu versuchen? (J/j)");
            string neuesspiel = Console.ReadLine();
            neuesspiel = neuesspiel.ToUpper();
            if (neuesspiel == "J")
            {
                Console.Clear();
                Program.SpielStart();
            }
            else
            {
                Console.Clear();
            }
        }
        static public void Todzwei()
        {
            Console.Clear();
            Console.WriteLine("Du bist Tot");
            Console.WriteLine("Neu versuchen? (J/j");
            string neuesspiel_zwei = Console.ReadLine();
            neuesspiel_zwei = neuesspiel_zwei.ToUpper();
            if (neuesspiel_zwei == "J")
            {
                Console.Clear();
                Program.SpielStart();
            }
        }
        
    }

}