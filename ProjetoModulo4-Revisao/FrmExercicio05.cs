using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo4_Revisao
{
    public partial class FrmExercicio05 : Form
    {
        public FrmExercicio05()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Digite o valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var valor = Convert.ToInt32(txtValor.Text.Trim());
            if (valor % 10 == 0 && valor % 5 == 0 && valor % 2 == 0)
            {
                lblResposta.Text = "Valor digitado é divivel por 10, 5 e 2";
            } else if (valor % 10 == 0 && valor % 5 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 10 e 5";
            } else if (valor % 10 == 0 && valor % 2 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 10 e 2";
            } else if (valor % 5 == 0 && valor % 2 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 5 e 2";
            } else if (valor % 10 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 10 ";
            } else if (valor % 5 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 5";
            } else if (valor % 2 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 2";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
