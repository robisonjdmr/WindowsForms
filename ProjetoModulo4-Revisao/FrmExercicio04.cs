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
    public partial class FrmExercicio04 : Form
    {
        public FrmExercicio04()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int valor = Convert.ToInt32(txtValor.Text.Trim());
            if(valor % 5 == 0 && valor % 3 == 0)
            {
                lblResposta.Text = "Valor Digitado é Divisivel por 5 e 3!";
            } else if (valor % 5 == 0)
            {
                lblResposta.Text = "Valor Digitado é Divisivel por 5!";
            }else if (valor % 3 == 0)
            {
                lblResposta.Text = "Valor Digitado é Divisivel por 3!";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
