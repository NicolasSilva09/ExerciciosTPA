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
    public partial class frmEx5 : Form
    {
        public frmEx5()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double p, a, imc;

            p = Convert.ToDouble(txtpeso.Text);
            a = Convert.ToDouble(txtaltura.Text);

            imc = p / (a * a);

            if (imc < 17)
            {
                txtimc.Text = ("Magreza Severa");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                txtimc.Text = ("Peso Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                txtimc.Text = ("Sobre Peso");
            }
            else if (imc >= 30 && imc < 35)
            {
                txtimc.Text = ("Obesidade I");
            }
            else if (imc >= 35 && imc < 40)
            {
                txtimc.Text = ("Obesidade II");
            }
            else if (imc >= 40)
            {
                txtimc.Text = ("Obesidade III");
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Focus();
            txtaltura.Clear();
            txtimc.Clear();
            txtpeso.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
