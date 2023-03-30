using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetomiguel
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void combustivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2 fm = new frm2();
            fm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void votaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm3 fm = new frm3();
            fm.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4 fm = new frm4();
            fm.Show();
        }
    }
}
