using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    public partial class frm1 : Form
    {
        InventarKlasse invObjekt = InventarKlasse.globalesInventar();
        //Random rnd = new Random();
        public frm1()
        {
            InitializeComponent();
            tm.Interval = 500;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
            tm3.Interval = 500;
            tm3.Tick += new EventHandler(Timer_tickAgain);
            tm3.Start();
            prg_Lebens();
        }
        Timer tm3 = new Timer();
        Timer tm = new Timer();
        int X = 0;
        int Y = 0;
        int goblins = 10;
        int counter = 0;
        static int leben = 50;
        void tm_Tick(object sender, EventArgs e)
        {
            X = ((int)(new Random().Next(0, 550)));
            Y = ((int)(new Random().Next(0, 550)));
            if (X > 550 - Goblin.Width)
                X = 550 - Goblin.Width;
            if (Y > 550 - Goblin.Height)
                Y = 550 - Goblin.Height;
            Goblin.Location = new Point(X, Y);
        }
        public void Clicks(object sender, EventArgs e)
        {
            goblins--;
            if (goblins <= 0)
            {
                tm.Stop();
                tm3.Stop();
                MessageBox.Show("Axt gefunden!");
                invObjekt.Item_mehr("Axt");
                Form formz = new frm_ork();
                formz.Visible = true;
                this.Hide();
            }
        }
        private void prg_Lebens()
        {
            prg_Leben.Style = ProgressBarStyle.Continuous;
            prg_Leben.Minimum = 0;
            prg_Leben.Maximum = 50;
            prg_Leben.Value = 50;
            prg_Leben.ForeColor = Color.Green;
        }
        void Timer_tickAgain(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 45)
            {
                tm3.Stop();
                tm.Stop();
            }
            leben--;
            prg_Leben.Value--;
            if (prg_Leben.Value <= 5)
            {
                tm.Stop();
                tm3.Stop();
                MessageBox.Show("Du bist Gestorben!");
                Form formes = new Form3();
                formes.Visible = true;
                this.Hide();
            }
        }
        public static int lebenzahl()
        {
            return leben;
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
