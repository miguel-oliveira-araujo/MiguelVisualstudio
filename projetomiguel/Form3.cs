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
    public partial class frm3 : Form
    {
        double p1 = 0, p2 = 0, p3 = 0, v, t, p;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public frm3()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            p1 = 0;
            p2 = 0;
            p3 = 0;

            txtr.Clear();
            txtv.Focus();
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            t = p1 + p2 + p3;

            if (p1 > p2 && p1 > p3)
            {
                p = (100 * p1) / t;
                txtr.Text = "O ganhador é José da Silva com " + p1 + " votos. Total de votos da votação: " + t + " .E com " + p + "%";
            }
            if (p2 > p1 && p2 > p3)
            {
                p = (100 * p2) / t;
                txtr.Text = "O ganhador é Maria Juruma com " + p2 + " votos. Total de votos da votação: " + t + " .E com " + p + "%";
            }
            if (p3 > p2 && p3 > p1)
            {
                p = (100 * p3) / t;
                txtr.Text = "O ganhador é João da Tapioca com " + p3 + " votos. Total de votos da votação: " + t + " .E com " + p + "%";
            }
        }

        private void btnvotar_Click(object sender, EventArgs e)
        {


            v = Convert.ToDouble(txtv.Text);



            if (v == 1)
                p1++;
            if (v == 2)
                p2++;
            if (v == 3)
                p3++;
            txtv.Clear();
            txtv.Focus();
        }
    }
 }

