using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SpielStart();
        }
        public static void SpielStart()
        {
            InventarKlasse invObjekt = InventarKlasse.globalesInventar();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                      ^                                      ");
            Console.WriteLine("                                     <|>                                     ");
            Console.WriteLine("                                    <<|>>                                    ");
            Console.WriteLine("                                   <<<|>>>                                   ");
            Console.WriteLine("                                  <<<<|>>>>                                  ");
            Console.WriteLine("                                 <<<<<|>>>>>                                 ");
            Console.WriteLine("                                <<<<<<|>>>>>>                                ");
            Console.WriteLine("                               <<<<<<<|>>>>>>>                               ");
            Console.WriteLine("                              <<<<<<<<|>>>>>>>>                              ");
            Console.WriteLine("                             <<<<<<<<<|>>>>>>>>>                             ");
            Console.WriteLine("                            <<<<<<<<<<|>>>>>>>>>>                            ");
            Console.WriteLine("                           <<<<<<<<<<<|>>>>>>>>>>>                           ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                   ||||||||                                  ");
            Console.WriteLine("                                   ||||||||                                  ");
            Console.WriteLine("                                   ||||||||                                  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Willst du anfangen?");
            Console.WriteLine("Einleitung");
            Console.WriteLine("Um die Hilfe abzurufen gib ,Hilfe, ein");
            string neuesspiel = Console.ReadLine();
            neuesspiel = neuesspiel.ToLower();
            if (neuesspiel == "ja")
            {
                Console.Clear();
                Gebiet_1.Höhle();
            }
            else if (neuesspiel == "hilfe")
                Help.Hilfe();
            else if (neuesspiel == "cheating")
            {
                invObjekt.Item_mehr("Wolfspelz");
                invObjekt.Item_mehr("Bogen");
                Gebiet_2.Tal();
            }
            else if (neuesspiel == "quick")
                Gebiet_3.Goblinkampf();
            else
            {
                Console.WriteLine("Falsche Eingabe!");
                Program.SpielStart();
            }
           
        }


     }
}