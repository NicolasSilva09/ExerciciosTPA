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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double idade, salarioA, salarioN,sexo;
            string nome;

            nome = txtnome.Text;
            idade = Convert.ToDouble(txtidade.Text);
            sexo = Convert.ToDouble(txtsexo.Text);
            salarioA = Convert.ToDouble(txtatual.Text);

            if (sexo == 1 && idade >= 30)
            {
                salarioN = salarioA + 100;
                txtnovo.Text =salarioN.ToString();
            }
            else if (sexo == 1 && idade < 30)
            {
                salarioN = salarioA + 50;
                txtnovo.Text =salarioN.ToString();
            }
            if (sexo == 2 && idade >= 30)
            {
                salarioN = salarioA + 250;
                txtnovo.Text =salarioN.ToString();
            }
            else if (sexo == 2 && idade < 30)
            {
                salarioN = salarioA + 150;
                txtnovo.Text =salarioN.ToString();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnovo.Clear();
            txtidade.Clear();
            txtsexo.Clear();
            txtatual.Clear();
            txtnome.Clear();
            txtnome.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu f4 = new frmMenu();
            f4.Show();
        }
    }
}
