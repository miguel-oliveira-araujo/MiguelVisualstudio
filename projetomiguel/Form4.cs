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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n, t, i;
            n = Convert.ToDouble(txtn.Text);
            i = 1;
            while (i <= 10)
            {
                t = n * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", n.ToString() + "x" + i.ToString() + "=" + t.ToString());
                i++;
            }
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double x, t, i;
            x = Convert.ToDouble(txtn.Text);
            i = 1;
            for (i = 0; i <= 10; i++)
            {
                t = x * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", x.ToString() + "x" + i.ToString() + "=" + t.ToString());

            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            double x, t, i;
            x = Convert.ToDouble(txtn.Text);
            i = 1;
            do
            {
                t = x * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", x.ToString() + "x" + i.ToString() + "=" + t.ToString());
                i++;
            } while (i <= 10);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtr.Clear();
            txtn.Focus();
        }
    }
}
