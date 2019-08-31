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
    public partial class FrmFlowLayoutPainel : Form
    {
        public FrmFlowLayoutPainel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGroupBox formGrupoBox = new FrmGroupBox();
            formGrupoBox.ShowDialog();
        }

        private void btnFormPainel_Click(object sender, EventArgs e)
        {
            FrmPainel formPainel = new FrmPainel();
            formPainel.ShowDialog();
        }

        private void btnFormSplitContainer_Click(object sender, EventArgs e)
        {
            FrmSplitContainer formSplitContainer = new FrmSplitContainer();
            formSplitContainer.ShowDialog();
        }

        private void btnTabControl_Click(object sender, EventArgs e)
        {
            FrmTabControl formTabControl = new FrmTabControl();
            formTabControl.ShowDialog();
        }

        private void btnFormTabelLayoutPanel_Click(object sender, EventArgs e)
        {
            FrmTabelLayoutPanel formTabelLayoutPanel = new FrmTabelLayoutPanel();
            formTabelLayoutPanel.ShowDialog();
        }
    }
}
