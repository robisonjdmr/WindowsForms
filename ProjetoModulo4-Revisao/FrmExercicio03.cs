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
    public partial class FrmExercicio03 : Form
    {
        public FrmExercicio03()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtValor.Text.Trim());
            if (valor % 5 == 0)
            {
                lblResposta.Text = "Valor digitado é divisivel por 5";
            } else
            {
                lblResposta.Text = "Valor digitado não é divisivel por 5";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
