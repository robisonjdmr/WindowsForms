using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoModulo4_Revisao
{
    public partial class FrmMenu : Form
    {
        private Form _objFom;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio01
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio02
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio03
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio04
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio05
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _objFom?.Close();

            _objFom = new FrmExercicio06
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objFom);
            _objFom.Show();
        }
    }
}
