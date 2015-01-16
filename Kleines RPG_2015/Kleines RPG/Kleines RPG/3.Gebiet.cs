using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    class Gebiet_3
    {
        [STAThread]
        public static void Goblinkampf()
        {
            Console.Clear();
            Console.WriteLine("Eine Horde Goblins mit einem Ork als Anführer attackiert dich!");
            Console.ReadKey();
            Application.EnableVisualStyles();
            Application.Run(new frm1());
        }
        public static void Zurück()
        {
            Console.Clear();
            Console.WriteLine("Kampf gewonnen!");
            Console.WriteLine("Lvl up! 1 Skillpunkt erhalten.");
        }
    }
}