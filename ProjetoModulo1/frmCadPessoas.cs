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
    public partial class FrmCadPessoas : Form
    {
        public FrmCadPessoas()
        {
            InitializeComponent();
        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            Text = "Novo Titulo";
        }

        private void btnChamaOutroForm_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos form = new FrmCadVeiculos();

            form.strPlaca = txtPlaca.Text.Trim();
            form.Text = "Cadastro de Veiculos";
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(100, 100);
            form.ShowDialog();
            txtResposta.Text = form.txtResposta.Text;
        }        
    }
}
