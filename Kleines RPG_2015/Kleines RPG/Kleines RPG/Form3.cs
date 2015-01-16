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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tm.Interval = 5000;
            tm.Tick += new EventHandler(buttonAppear);
            tm.Start();
            this.btn_nein.FlatAppearance.BorderSize = 0;
            this.btn_ja.FlatAppearance.BorderSize = 0;
            tbx_Frage.BorderStyle = 0;
        }
        int counter = 0;
        private void btn_ja_Click(object sender, EventArgs e)
        {
            Form formes = new frm1();
            formes.Visible = true;
            this.Hide();
        }

        private void btn_nein_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Timer tm = new Timer();
        void buttonAppear(object sender, EventArgs e)
        {
            counter++;
            if(counter == 1)
            {
                tm.Stop();
                btn_ja.Visible = true;
                btn_nein.Visible = true;
                tbx_Frage.Visible = true;
            }
        }
    }
}
