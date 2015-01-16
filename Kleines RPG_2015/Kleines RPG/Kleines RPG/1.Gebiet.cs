using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Gebiet_1
    {

        static public void Höhle()
        {
            int spieler_leben = 15;
            int wolfleben = Gegner.Wolfsleben();
            InventarKlasse invObjekt = InventarKlasse.globalesInventar();
            Console.WriteLine("Gebiet 1: Wolf");
            Console.WriteLine();
            Console.WriteLine("STORY");
            Console.WriteLine("Story");
            Console.WriteLine("Story");
            Console.WriteLine("story");
            Console.WriteLine("story");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("links rechts abfragen");
            string aktion = Console.ReadLine();
            aktion = aktion.ToLower();
            if (aktion == "links")
            {
                Console.WriteLine();
                Console.WriteLine("Story");
            }
            else if (aktion == "rechts")
            {
                Console.WriteLine("falsch, falle");
                Tod.Todzwei();
            }
            else
            {
            Console.WriteLine("Falsche Eingabe");
            Console.WriteLine("Zurück zum Anfang des Gebietes!");
            Gebiet_1.Höhle();
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Angreifen frage , ja nein");
            string aktiondrei = Console.ReadLine();
            aktiondrei = aktiondrei.ToLower();
            if (aktiondrei == "ja")
            {
                Console.Clear();
                Console.WriteLine("Du schlägst den Wolf");
                Console.WriteLine("Wolf wacht auf, attackiert dich.");
                Console.WriteLine("Du hast {0} Leben" ,spieler_leben);
                Console.WriteLine("Wolf macht 15 Schaden");
                spieler_leben = spieler_leben - Gegner.Wolfsschaden();
                Tod.KeinLeben();
            }
            else if (aktiondrei== "nein")
                Console.WriteLine("weiter");
            else
            {
                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Zurück zum Anfang des Gebietes!");
                Gebiet_1.Höhle();
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Bogen gefunden ja nein");
            string aktionvier = Console.ReadLine();
            aktionvier = aktionvier.ToLower();
            if (aktionvier== "ja")
            {
                invObjekt.Item_mehr("Bogen");
                Console.WriteLine("Bogen erhalten.");
            }
            else if (aktionvier == "nein")
            {
                Console.WriteLine("Gegenstand wird benötigt um fortzufahren");
                Gebiet_1.Höhle();
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Zurück zum Anfang des Gebietes!");
                Gebiet_1.Höhle();
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Pfeil gefunden.");
            Console.WriteLine("Aufheben?");
            string aktionfünf = Console.ReadLine();
            aktionfünf = aktionfünf.ToLower();
            if (aktionfünf == "ja")
            {
                invObjekt.Item_mehr("Pfeil");
                Console.WriteLine("Pfeil erhalten.");
            }
            else
            {
                Console.WriteLine("Falsche Eingabe!");
                Gebiet_1.Höhle();
            }
            Console.Clear();
            Console.WriteLine("Angreiffen?");
            Console.WriteLine("Ja");
            string aktionsechs = Console.ReadLine();
            aktionsechs = aktionsechs.ToLower();
                if (aktionsechs == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Bogen benutzen?");
                    string bogenbenutzen = Console.ReadLine();
                    bogenbenutzen = bogenbenutzen.ToLower();
                    if (bogenbenutzen == "ja")
                    {
                        wolfleben = Gegner.Wolfsleben() - Stats.Schadenausteilen();
                        if (wolfleben <= 0)
                        {
                            Console.WriteLine("Gewonnen!");
                            Console.WriteLine("Level Up!");
                            Console.WriteLine("Du hast nun 30 Leben und bist lvl 2!");
                            Console.WriteLine("1 Skillpunkt erhalten!");
                            Console.WriteLine("Pfeil verloren!");
                            invObjekt.ItemEntfernen("Pfeil");
                            invObjekt.Item_mehr("Wolfspelz");
                            Console.WriteLine("Wolfspelz erhalten");
                            Console.WriteLine("weitergehen?");
                            string weitergehen = Console.ReadLine();
                            weitergehen = weitergehen.ToLower();
                            if (weitergehen == "ja")
                                Gebiet_2.Tal();
                        }
                    }
                    else if (bogenbenutzen == "nein")
                    {
                        Console.WriteLine("Wolf wacht auf, du tot");
                        Console.WriteLine("Tot");
                        Tod.KeinLeben();
                    }
                }
                else if (aktionsechs == "nein")
                {
                    Console.WriteLine("So wird es nich weitergehn");
                    Gebiet_1.Höhle();
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Zurück zum Anfang des Gebietes!");
                    Gebiet_1.Höhle();
                }
        }
    }
}