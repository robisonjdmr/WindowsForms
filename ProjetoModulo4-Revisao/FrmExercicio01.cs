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
    public partial class FrmExercicio01 : Form
    {
        public FrmExercicio01()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtValor1.Text) + Convert.ToInt32(txtValor2.Text);
            
            if(resultado < 10)
            {
                MessageBox.Show("Resultado menor que 10");
            }else if (resultado > 10)
            {
                lblResultado.Text = resultado.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
