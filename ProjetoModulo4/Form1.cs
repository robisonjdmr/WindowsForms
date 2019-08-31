using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num1 = 12, num2 = 20;
            var soma = num1 + num2;
            lblSoma.Text = soma.ToString();

            lstTabuada.Clear();
            //valor1 sinal valor2 = resultado
            lstTabuada.Columns.Insert(0, "Valor",100, HorizontalAlignment.Center);
            lstTabuada.Columns.Insert(1, "Sinal",50 , HorizontalAlignment.Center);
            lstTabuada.Columns.Insert(2, "Valor",100, HorizontalAlignment.Center);
            lstTabuada.Columns.Insert(3, "Igual", 50, HorizontalAlignment.Center);
            lstTabuada.Columns.Insert(4, "Resultado",100, HorizontalAlignment.Center);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean result1 = textBox1.Text.Trim().Equals(String.Empty);
            Boolean result2 = textBox2.Text.Trim().Equals(String.Empty);
            if (result1 == true || result2 == true)
            {
                MessageBox.Show("Insira todos os valores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero1, numero2;
            numero1 = Convert.ToInt32(textBox1.Text.Trim());
            numero2 = Convert.ToInt32(textBox2.Text.Trim());
            label1.Text = ($" A soma é {numero1 + numero2}").ToString();
            label2.Text = ($"A subtração é {numero1 - numero2}").ToString();
            label3.Text = ($"A multiplicação é {numero1 * numero2}").ToString();
            label4.Text = ($"A divisão é {numero1 / numero2}").ToString();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            valor1 = Convert.ToInt32(textBox3.Text.Trim());
            valor2 = Convert.ToInt32(textBox4.Text.Trim());
            if(valor1 > valor2)
            {
                vlMaior.Text = valor1.ToString();
            } else if(valor1 < valor2)
            {
                vlMaior.Text = valor2.ToString();
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (txtTeste.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Informe o dia da semana", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int iDia = Convert.ToInt32(txtTeste.Text.Trim());
            switch (iDia)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda-Feira");
                    break;
                case 3:
                    MessageBox.Show("Terça-Feira");
                    break;
                case 4:
                    MessageBox.Show("Quarta-Feira");
                    break;
                case 5:
                    MessageBox.Show("Quinta-Feira");
                    break;
                case 6:
                    MessageBox.Show("Sexta-Feira");
                    break;
                case 7:
                    MessageBox.Show("Sabado");
                    break;
                default:
                    MessageBox.Show("Dia não reconhecido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            if (txtTabuada.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Você deverá informar um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTabuada.Focus();
                return;
            }
            int valorLido = Convert.ToInt32(txtTabuada.Text.Trim());
            int qtDeRepeticao = Convert.ToInt32(txtQtDeRepeticoes.Text.Trim());
            int i = 0;
            lstTabuada.Items.Clear();
            /*for (int i = 0; i <= qtDeRepeticao; i++)
            {
               
                ListViewItem itmx = lstTabuada.Items.Add(valorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "X"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (valorLido * i).ToString()));

            }*/
            /*while(i <= qtDeRepeticao)
            {

                ListViewItem itmx = lstTabuada.Items.Add(valorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "X"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (valorLido * i).ToString()));
                i++;
            }*/
            do
            {
                ListViewItem itmx = lstTabuada.Items.Add(valorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "X"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (valorLido * i).ToString()));
                i++;
            } while (i <= qtDeRepeticao);




            //Trabalhando com vetores
            int[] vetor;
            int iPrimeiroValor;
            int soma = 0;
            int index;
            vetor = new int[10];
            vetor[0] = 20;
            vetor[1] = 50;
            vetor[2] = 59;
            vetor[3] = 32;
            vetor[4] = 15;
            vetor[5] = 10;
            vetor[6] = 5;
            vetor[7] = 9;
            vetor[8] = 3;
            vetor[9] = 21;

            iPrimeiroValor = vetor[0];

            for (index = 0; index < 10; index++)
            {
                soma = soma + vetor[index];
            }

            index = 0;
            while(index < 10)
            {
                soma = soma + vetor[index];
                index++;
            }

            index = 0;
            do
            {
                soma = soma + vetor[index];
                index++;
            } while (index < 10);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            txtTabuada.Text = "";
            txtQtDeRepeticoes.Text = "";
        }
    }
}
