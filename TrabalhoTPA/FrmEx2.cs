using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTPA
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double quant, total;
            quant=Convert.ToDouble(txtquant.Text);

            if (quant >=10)
            {
                total = 12 * quant;
                txttotal.Text=total.ToString();
            }
            else
            {
                total = 8 * quant;
                txttotal.Text=total.ToString();
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtquant.Clear();
            txtquant.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu f4 = new frmMenu();
            f4.Show();
        }
    }
}
