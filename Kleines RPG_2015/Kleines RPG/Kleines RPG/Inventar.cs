using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class InventarKlasse
    {
        private static InventarKlasse global;
        private List<string> items;
        public void Item_mehr(string name)
        {
            items.Add(name);
        }
        public int Itemszählen()
        {
            int zählen = items.Count;
            return zählen;
        }
        public void ItemEntfernen(string name)
        {
            int x;
            while ((x = items.IndexOf(name)) >= 0)
                items.RemoveAt(x);
        }
        public bool Item (string name)
        {
            return items.Contains(name);
        }
        public void Itemsanzeigen()
        {
            for (int x = 0; x < items.Count; x++)
            {
                Console.WriteLine(items[x]);
            }
        }
        public InventarKlasse()
        {
            items = new List<string>();
        }
        public static InventarKlasse globalesInventar()
        {
            if(global == null)
                global = new InventarKlasse();
            return global;
        }
    }
}