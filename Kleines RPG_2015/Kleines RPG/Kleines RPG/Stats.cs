using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace RPG
{
    class Stats
    {
        static InventarKlasse invObjekt = InventarKlasse.globalesInventar();
        static int schaden;
        static int mana = 0; 
        static public int Schadenausteilen()
        {
            if (invObjekt.Item("Pfeil") == true && invObjekt.Item("Bogen") == true)
            {
                schaden = 10;
                invObjekt.ItemEntfernen("Pfeil");
            }
            if (invObjekt.Item("Axt") == true)
            {
                schaden = 15;
            }
            if (invObjekt.Item("Armbrust") == true && invObjekt.Item("Bolzen") == true)
            {
                schaden = 30;
                invObjekt.ItemEntfernen("Bolzen");
            }
            return schaden;
        }
        static public int SchadenMagie()
        {
            if (invObjekt.Item("Feuerball") == true)
            {
                schaden = 200;
                mana = mana - 10;
                invObjekt.ItemEntfernen("Feuerball");
            }
            return schaden;
        }
    }
}