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
    public partial class FrmCadVeiculos : Form
    {
        public String strPlaca;
        public String strResposta;

        public FrmCadVeiculos()
        {
            InitializeComponent();
        }

        private void FrmCadVeiculos_Load(object sender, EventArgs e)
        {
            lblPlaca.Text = strPlaca;
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            strResposta = txtResposta.Text.Trim();
        }
    }
}
