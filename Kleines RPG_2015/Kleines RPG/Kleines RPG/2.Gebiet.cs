using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Gebiet_2
    {
        static public void Tal()
        {
            int trollleben = Gegner.Trollleben();
            Console.Clear();
            Console.WriteLine("Gebiet 2: Tal");
            Console.WriteLine("StoryText");
            Console.WriteLine("StoryText");
            Console.WriteLine("StoryText");
            Console.WriteLine("StoryText");
            Console.WriteLine();
            InventarKlasse invObjekt = InventarKlasse.globalesInventar();
            Console.Clear();
            Console.WriteLine("Du erfrierst!");
            Console.WriteLine("Pelz benutzen?");
            string aktion = Console.ReadLine();
            aktion = aktion.ToLower();
            if (aktion == "ja")
            {
                invObjekt.ItemEntfernen("Wolfspelz");
                Console.WriteLine("Wolfspelz verwendet.");
            }
            else if (aktion == "nein")
            {
                Console.WriteLine("Zu gierig. Tod.");
                Tod.Todzwei();
            }
            else
            {
                Console.WriteLine("Falsche Eingabe!");
                Console.WriteLine("Zurück zum Start.");
                Gebiet_2.Tal();
            }
            Console.Clear();
            Console.WriteLine("Spruchrolle gefunden!");
            Console.WriteLine("Spruchrolle aufgehoben : Feuerball");
            invObjekt.Item_mehr("Feuerball");
            Console.Clear();
            invObjekt.Itemsanzeigen();
            Console.WriteLine("story.... wandern... schlafen....");
            Console.WriteLine("Troll gehört");
            Console.WriteLine("Laufen?");
            string trollaktioneins = Console.ReadLine();
            trollaktioneins = trollaktioneins.ToLower();
            if (trollaktioneins == "ja")
            {
                Console.Clear();
                Console.WriteLine("Troll wirft Stein");
                Console.WriteLine("Du Tot");
                Tod.Todzwei();
            }
            else if (trollaktioneins == "nein")
            {
                Console.Clear();
                Console.WriteLine("Troll bekämpfen!");
                Console.WriteLine("keine Pfeile mehr!");
                Console.WriteLine("Spruchrolle?");
                string trollaktionzwei = Console.ReadLine();
                trollaktionzwei = trollaktionzwei.ToLower();
                if (trollaktionzwei == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Feuerball benutzt.");
                    Console.WriteLine("200 Feuerschaden auf Troll");
                    trollleben = Gegner.Trollleben() - Stats.SchadenMagie();
                    if (trollleben <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Troll tot.");
                        Console.WriteLine("Level 2 erreicht!");
                        Console.WriteLine("1 Skillpunkt erhalten!");
                        Gebiet_3.Goblinkampf();
                    }
                }
                else if (trollaktionzwei == "nein")
                {
                    Console.Clear();
                    Console.WriteLine("Warum nicht?");
                    Console.WriteLine("Keine Gegenwehr, du stirbst.");
                    Tod.KeinLeben();
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                    Gebiet_2.Tal();
                }
            }
            else
            {
                Console.WriteLine("Falsche Eingabe!");
                Gebiet_2.Tal();
            }
        }
    }
}