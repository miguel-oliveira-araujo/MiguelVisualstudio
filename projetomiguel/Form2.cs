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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            {
                double l, t;
                string c;


                l = Convert.ToDouble(txtl.Text);
                c = Convert.ToString(txtc.Text);

                if (c == "g")
                {
                    if (l <= 20)
                    {
                        t = l * 5.28;
                        txtt.Text = "R$" + t;
                    }
                    else
                    {
                        t = l * 5.17;
                        txtt.Text = "R$" + t;
                    }

                }
                if (c == "a")
                {
                    if (l <= 20)
                    {
                        t = l * 4.753;
                        txtt.Text = "R$" + t;
                    }
                    else
                    {
                        t = l * 4.655;
                        txtt.Text = "R$" + t;
                    }
                }



            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtl.Clear();
            txtt.Clear();
            txtc.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }
    }
}
