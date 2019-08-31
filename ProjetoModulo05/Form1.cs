using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo05
{
    public partial class Form1 : Form
    {
        int X, Y;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(pnlPrincipal_MouseDown);
            this.MouseMove += new MouseEventHandler(pnlPrincipal_MouseMove);
        }
        private void pnlPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void pnlPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Primeira forma
            //MessageBox.Show(System.Environment.CurrentDirectory);

            //Segunda  Forma
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            String nomeArt = "Arquivo.txt";
            if (File.Exists(nomeArt))
            {
                MessageBox.Show("Arquivo Existe");
            } else
            {
                MessageBox.Show("Arquivo não existe");
                Stream arquivo = File.Create(nomeArt);
                arquivo.Close();
            }
          

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String nomeArt = "Arquivo.txt";
            if (File.Exists(nomeArt))
            {
                MessageBox.Show("Arquivo Existe");
                File.Delete(nomeArt);
            } else
            {
                MessageBox.Show("Arquivo não existe");
                Stream arquivo = File.Create(nomeArt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomePasta = @"C:\Users\Robison\Desktop\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\Exemplos";
            String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
            if (!Directory.Exists(nomePasta))
            {
                Directory.CreateDirectory(nomePasta);
            }
            if (!File.Exists(nomeArq))
            {
                File.Create(nomeArq);
            }
            
        }

        private void btnrenomearPasta_Click(object sender, EventArgs e)
        {

            if (!txtNomePasta.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"C:\Users\Robison\Desktop\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\Exemplos";
                Directory.Move(txtNomeAtual.Text.Trim(), txtNomePasta.Text.Trim());
            }
            txtNomeAtual.Text = "";
            txtNomePasta.Text = "";
        }

        private void btnRenomearArquivo_Click(object sender, EventArgs e)
        {
            if (!txtNovoNomeArquivo.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"C:\Users\Robison\Desktop\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\CursoCSharp";
                            

                File.Move(nomePasta + @"\" + txtNomeArquivoAtual.Text.Trim(), nomePasta + @"\"+ txtNovoNomeArquivo.Text.Trim());
            }
            txtNomeArquivoAtual.Text = "";
            txtNovoNomeArquivo.Text = "";
        }

        private void btnLeitura_Click(object sender, EventArgs e)
        {
            String nomeArt = @"E:\cursos extensivos\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\CursoCSharp\PrimeiroExemplo.txt";
            if (File.Exists(nomeArt))
            {
                String[] array = File.ReadAllLines(nomeArt);
                lstLeitura.Items.Clear();
                foreach(var item in array)
                {
                    lstLeitura.Items.Add(item);
                }
            }  
        }

        private void btnLeitura2_Click(object sender, EventArgs e)
        {
            String nomeArt = @"E:\cursos extensivos\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\CursoCSharp\PrimeiroExemplo.txt";
            if (File.Exists(nomeArt))
            {
                //Primeira Forma
                /*StreamReader reader = new StreamReader(nomeArt);
                String linha;
                lstLeitura.Items.Clear();
                while((linha = reader.ReadLine()) != null)
                {
                    lstLeitura.Items.Add(linha);
                }
                reader.Close();*/
                //Segunda forma
                using (StreamReader reader = new StreamReader(nomeArt))
                {
                    String linha;
                    lstLeitura.Items.Clear();
                    while ((linha = reader.ReadLine()) != null)
                    {
                        lstLeitura.Items.Add(linha);
                    }
                }
            }
        }

        private void btnLeitura3_Click(object sender, EventArgs e)
        {
            String nomeArt = @"E:\cursos extensivos\Curso de C-sharp\Windows_Forms\ProjetoModulo05\ProjetoModulo05\bin\Debug\CursoCSharp\PrimeiroExemplo.txt";
            if (File.Exists(nomeArt))
            {
                //Primeira Forma
                /*StreamReader reader = File.OpenText(nomeArt);
                lstLeitura.Items.Clear();
                while (!reader.EndOfStream)
                {
                    String linha = reader.ReadLine();
                    lstLeitura.Items.Add(linha);
                }

                reader.Close();*/
                //Segunda Forma
                using (StreamReader reader = File.OpenText(nomeArt))
                {
                    lstLeitura.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        String linha = reader.ReadLine();
                        lstLeitura.Items.Add(linha);
                    }
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            String nomeArq;            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                nomeArq = openFile.FileName;
                using (StreamReader reader = new StreamReader(nomeArq))
                {
                    String linha;
                    lstLeitura.Items.Clear();
                    while ((linha = reader.ReadLine()) != null)
                    {
                        lstLeitura.Items.Add(linha);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nomeArq;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                nomeArq = openFile.FileName;
                using(StreamReader reader = new StreamReader(nomeArq))
                {
                    StreamWriter writer = new StreamWriter(nomeArq);

                }

            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}

