using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            var f = new Frm_Demonstracao();
            f.ShowDialog();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            var f = new frm_HelloWorld();
            f.ShowDialog();
        }

        private void btn_Mascara_Click(object sender, EventArgs e)
        {
            var f = new frm_Mascara();
            f.ShowDialog();
        }

        private void btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            var f = new frm_ValidaCPF();
            f.ShowDialog();
        }

        private void btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            var f = new frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaSenha();
            f.ShowDialog();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
