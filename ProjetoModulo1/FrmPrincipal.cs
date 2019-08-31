using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }         

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadPeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPessoas form = new FrmCadPessoas();
            form.MdiParent = this;
            form.Show();
        }

        private void abrirCadVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos form = new FrmCadVeiculos();
            form.MdiParent = this;
            form.Show();
        }
    }
}
