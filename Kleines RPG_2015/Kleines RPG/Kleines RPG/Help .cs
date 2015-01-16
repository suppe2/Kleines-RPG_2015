using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Help
    {
        static public void Hilfe()
        {
            Console.WriteLine("Sie haben die Hilfe abgerufen");
            Console.WriteLine("Um sie wieder zu verlassen geben sie bitte : 'Verlassen' ein");
            Console.WriteLine("Da dies eine Konsolenanwendung ist dürfen ihre Eingaben keine Fehler enthalten.");
            Console.WriteLine("Dieses Programm toleriert Groß und Kleinschreibung");
            Console.WriteLine("Geben sie 'Lösung' ein um die Lösungen anzusehen.");
            if (Console.ReadLine() == "Lösung" || Console.ReadLine() == "lösung")
                Lösung.lösung();
        }
    }
}