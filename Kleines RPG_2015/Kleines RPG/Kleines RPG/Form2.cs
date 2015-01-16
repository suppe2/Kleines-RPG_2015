using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class frm_ork : Form
    {
        InventarKlasse invObjekt = InventarKlasse.globalesInventar();
        public frm_ork()
        {
            InitializeComponent();
            tm3.Interval = 500;
            tm3.Tick += new EventHandler(Timer_tickAgain);
            tm3.Start();
            prg_Lebens();
        }
        Timer tm3 = new Timer();
        int ork_leben = 100;
        void Timer_tickAgain(object sender, EventArgs e)
        {
            prg_Leben.Value = prg_Leben.Value - 3;
            if (prg_Leben.Value <= 7)
            {
                tm3.Stop();
                MessageBox.Show("Du bist Gestorben!");
                Form formes = new Form3();
                formes.Visible = true;
                this.Hide();
            }

        }
        private void prg_Lebens()
        {
            prg_Leben.Style = ProgressBarStyle.Continuous;
            prg_Leben.Minimum = 0;
            prg_Leben.Maximum = 50;
            prg_Leben.Value = frm1.lebenzahl();
            prg_Leben.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ork_leben = ork_leben - Stats.Schadenausteilen();
            if(ork_leben <= 0)
            {
                tm3.Stop();
                MessageBox.Show("Gewonnen!");
                Gebiet_3.Zurück();
            }
        }

    }

}
