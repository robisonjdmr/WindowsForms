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
    public partial class FrmExercicio02 : Form
    {
        public FrmExercicio02()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtImparPar.Text);
            if(resultado % 2 == 0)
            {
                lblImparPar.Text = "Valor digitado é numero PAR";
            } else
            {
                lblImparPar.Text = "Valor digitado é numero IMPAR";
            }
        }
    }
}
