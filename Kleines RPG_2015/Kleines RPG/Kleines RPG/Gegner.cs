using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Gegner
    {
        static public int Wolfsschaden()
        {
            int wolfschaden = 15;
            return wolfschaden;
        }
        static public int Wolfsleben()
        {
            int wolfsleben = 10;
            return wolfsleben;
        }
        static public int Trollschaden()
        {
            int trollSchaden = 25;
            return trollSchaden;
        }
        static public int Trollleben()
        {
            int trollleben = 150;
            return trollleben;
        }
        static public int GoblinLeben()
        {
            int goblinleben = 5;
            return goblinleben;
        }
        static public int GoblinSchaden()
        {
            int goblinschaden = 5;
            return goblinschaden;
        }
    }
}