using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnNao.Visible = false;
            this.btnNao1.Visible = true;
            
            
        }

        private void btnNao2_Click(object sender, EventArgs e)
        {
            this.btnNao.Visible = false;
            this.btnNao1.Visible = false;
            this.btn2.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.btnNao.Visible = false;
            this.btnNao1.Visible = false;
            this.btn2.Visible = false;
            this.btn3.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.btnNao.Visible = false;
            this.btnNao1.Visible = false;
            this.btn2.Visible = false;
            this.btn3.Visible = false;
            this.btn4.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.btnNao.Visible = false;
            this.btnNao1.Visible = false;
            this.btn2.Visible = false;
            this.btn3.Visible = false;
            this.btn4.Visible = false;
            this.btn5.Visible = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POXA NÃO QUER CRIAR UMA VIDA DE CASADAS JUNTINHAS???", "TOXICA",MessageBoxButtons.OK);
            Close();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EBAAAAAA, ENTÃO VAMOS CRIAR UMA VIDA JUNTINHAS CHEIA DE GATINHOS E MTO AMORR!!!!!!", "LINDA TE AMOOOO", MessageBoxButtons.OK);
            Close();
        }
    }
}
