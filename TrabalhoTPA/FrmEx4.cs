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
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            double pedido;

            pedido = Convert.ToInt32(txtescolha.Text);

            switch (pedido)
            {

                case 100:
                    txtfinal.Text = ("Cachorro-Quente   25,00R$");
                    break;

                case 101:
                    txtfinal.Text = ("Baurú  15,00R$");
                    break;

                case 102:
                    txtfinal.Text = ("X - Burguer   35,00R$");
                    break;

                case 103:
                    txtfinal.Text = ("Triplo X-Burguer   47,00R$");
                    break;

                default:
                    txtfinal.Text = ("Este pedido não existe");
                    break;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtescolha.Clear();
            txtfinal.Clear();
            txtescolha.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
