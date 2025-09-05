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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx1 f1= new frmEx1();
            f1.Show();
        }

        private void exercício1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx2 f2= new frmEx2();
            f2.Show();
        }

        private void exercício1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx3 f3= new frmEx3();  
            f3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx5 f5= new frmEx5();
            f5.Show();
        }

        private void exercício1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx4 f4= new frmEx4();
            f4.Show();
        }
    }
}
