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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double rendaT,publico,tipoI;
            double x1,y1,x2,y2,x3,y3,x4,y4;

            publico = Convert.ToDouble(txtpublico.Text);
            tipoI=Convert.ToDouble(txtingresso.Text);

            if (tipoI == 1)
            {
                x1 = publico * 0.10;
                y1 = 5 * x1;
                txtSetor.Text = y1.ToString();
            }

            if (tipoI == 2)
            {
                x2 = publico * 0.50;
                y2 = 10 * x2;
                txtSetor.Text = y2.ToString();
            }

            if (tipoI == 3)
            {
                x3 = publico * 0.30;
                y3 = 20 * x3;
                txtSetor.Text = y3.ToString();
            }

            if (tipoI == 4)
            {
                x4 = publico * 0.10;
                y4 = 30 * x4;
                txtSetor.Text = y4.ToString();
            }

            if (tipoI == 5)
            {
                rendaT = publico * 5 * 10 * 20 * 30;
                txttotal.Text= rendaT.ToString();
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtingresso.Clear();
            txtpublico.Clear();
            txtSetor.Clear();
            txttotal.Clear();
            txtpublico.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {

        }
    }
}
