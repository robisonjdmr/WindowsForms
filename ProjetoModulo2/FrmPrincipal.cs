using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo2
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
        //Fazend os comandos direto no metodo
        private void flowLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFlowLayoutPainel formFlowLayoutPainel = new FrmFlowLayoutPainel();
            formFlowLayoutPainel.MdiParent = this;
            formFlowLayoutPainel.StartPosition = FormStartPosition.Manual;
            formFlowLayoutPainel.Location = new Point(0, 0);
            formFlowLayoutPainel.Show();
        }
        //Fazendo uma estancia da função criada na linha 58 até 63
        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmGroupBox());
        }        

        private void painelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmPainel());
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmSplitContainer());
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmTabControl());
        }

        private void tabelLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmTabelLayoutPanel());
        }
        public void AbrirFormularios(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }
    }
}
