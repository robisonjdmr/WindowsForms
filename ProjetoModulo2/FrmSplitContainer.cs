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
    public partial class FrmSplitContainer : Form
    {
        public FrmSplitContainer()
        {
            InitializeComponent();
        }

        private void FrmSplitContainer_Load(object sender, EventArgs e)
        {
            lsbImagens.Items.Add("Chapolim");
            lsbImagens.Items.Add("Chaves");
            lsbImagens.Items.Add("Chesperito");
        }

        private void lsbImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbImagens.SelectedIndices.Count < 1) return;
            if(lsbImagens.SelectedIndex == 0)
            {
                lblInformacao.Text = "Informação Relacionada ao chapolim";
                pnlImagem.BackgroundImage = Properties.Resources.chapolin_;
            }
           else if(lsbImagens.SelectedIndex == 1)
            {
                lblInformacao.Text = "Informação Relacionada ao chaves";
                pnlImagem.BackgroundImage = Properties.Resources.Chaves;
            } else if (lsbImagens.SelectedIndex == 2)
            {
                lblInformacao.Text = "Informação Relacionada ao chesperto";
                pnlImagem.BackgroundImage = Properties.Resources.Chespirito;
            }



        }
    }
}
