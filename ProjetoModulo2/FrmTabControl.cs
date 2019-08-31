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
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tabControl1.Controls.Add(tabPageTeste3);
            }
            else
            {
                tabControl1.Controls.Remove(tabPageTeste3);
            }
        }

        private void FrmTabControl_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPageTeste3);
        }
    }
}
