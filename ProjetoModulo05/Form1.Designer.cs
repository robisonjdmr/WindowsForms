namespace ProjetoModulo05
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeArquivoAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenomearArquivo = new System.Windows.Forms.Button();
            this.txtNovoNomeArquivo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.lblPastaAtual = new System.Windows.Forms.Label();
            this.txtNomeAtual = new System.Windows.Forms.TextBox();
            this.txtNomePasta = new System.Windows.Forms.TextBox();
            this.btnrenomearPasta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnLeitura3 = new System.Windows.Forms.Button();
            this.btnLeitura2 = new System.Windows.Forms.Button();
            this.btnLeitura = new System.Windows.Forms.Button();
            this.lstLeitura = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileGravacao = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(183)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(183)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver directory padrão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Location = new System.Drawing.Point(6, 47);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(114, 30);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "Criar Arquivos";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(6, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 30);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Arquivos";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "AcessarDirectory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeArquivoAtual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRenomearArquivo);
            this.groupBox1.Controls.Add(this.txtNovoNomeArquivo);
            this.groupBox1.Location = new System.Drawing.Point(182, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renomear Arquivos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Novo Nome";
            // 
            // txtNomeArquivoAtual
            // 
            this.txtNomeArquivoAtual.Location = new System.Drawing.Point(13, 43);
            this.txtNomeArquivoAtual.Name = "txtNomeArquivoAtual";
            this.txtNomeArquivoAtual.Size = new System.Drawing.Size(181, 20);
            this.txtNomeArquivoAtual.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Arquivo Atual";
            // 
            // btnRenomearArquivo
            // 
            this.btnRenomearArquivo.FlatAppearance.BorderSize = 0;
            this.btnRenomearArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenomearArquivo.Location = new System.Drawing.Point(11, 133);
            this.btnRenomearArquivo.Name = "btnRenomearArquivo";
            this.btnRenomearArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnRenomearArquivo.TabIndex = 5;
            this.btnRenomearArquivo.Text = "Renomear";
            this.btnRenomearArquivo.UseVisualStyleBackColor = true;
            this.btnRenomearArquivo.Click += new System.EventHandler(this.btnRenomearArquivo_Click);
            // 
            // txtNovoNomeArquivo
            // 
            this.txtNovoNomeArquivo.Location = new System.Drawing.Point(12, 98);
            this.txtNovoNomeArquivo.Name = "txtNovoNomeArquivo";
            this.txtNovoNomeArquivo.Size = new System.Drawing.Size(182, 20);
            this.txtNovoNomeArquivo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNovoNome);
            this.groupBox2.Controls.Add(this.lblPastaAtual);
            this.groupBox2.Controls.Add(this.txtNomeAtual);
            this.groupBox2.Controls.Add(this.txtNomePasta);
            this.groupBox2.Controls.Add(this.btnrenomearPasta);
            this.groupBox2.Location = new System.Drawing.Point(388, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 244);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renomear Directory";
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.Location = new System.Drawing.Point(7, 79);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(64, 13);
            this.lblNovoNome.TabIndex = 4;
            this.lblNovoNome.Text = "Novo Nome";
            // 
            // lblPastaAtual
            // 
            this.lblPastaAtual.AutoSize = true;
            this.lblPastaAtual.Location = new System.Drawing.Point(7, 22);
            this.lblPastaAtual.Name = "lblPastaAtual";
            this.lblPastaAtual.Size = new System.Drawing.Size(92, 13);
            this.lblPastaAtual.TabIndex = 3;
            this.lblPastaAtual.Text = "Nome Pasta Atual";
            // 
            // txtNomeAtual
            // 
            this.txtNomeAtual.Location = new System.Drawing.Point(7, 43);
            this.txtNomeAtual.Name = "txtNomeAtual";
            this.txtNomeAtual.Size = new System.Drawing.Size(155, 20);
            this.txtNomeAtual.TabIndex = 2;
            // 
            // txtNomePasta
            // 
            this.txtNomePasta.Location = new System.Drawing.Point(6, 98);
            this.txtNomePasta.Name = "txtNomePasta";
            this.txtNomePasta.Size = new System.Drawing.Size(156, 20);
            this.txtNomePasta.TabIndex = 1;
            // 
            // btnrenomearPasta
            // 
            this.btnrenomearPasta.FlatAppearance.BorderSize = 0;
            this.btnrenomearPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrenomearPasta.Location = new System.Drawing.Point(5, 133);
            this.btnrenomearPasta.Name = "btnrenomearPasta";
            this.btnrenomearPasta.Size = new System.Drawing.Size(75, 23);
            this.btnrenomearPasta.TabIndex = 0;
            this.btnrenomearPasta.Text = "Renomear";
            this.btnrenomearPasta.UseVisualStyleBackColor = true;
            this.btnrenomearPasta.Click += new System.EventHandler(this.btnrenomearPasta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnCriar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 244);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar Arqvos e Directory";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.pnlPrincipal.Controls.Add(this.btnFechar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(817, 35);
            this.pnlPrincipal.TabIndex = 7;
            this.pnlPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(782, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProcurar);
            this.groupBox4.Controls.Add(this.btnLeitura3);
            this.groupBox4.Controls.Add(this.btnLeitura2);
            this.groupBox4.Controls.Add(this.btnLeitura);
            this.groupBox4.Controls.Add(this.lstLeitura);
            this.groupBox4.Location = new System.Drawing.Point(12, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 238);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Leitura de Arquivo";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(386, 29);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(114, 37);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar Arquivo";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnLeitura3
            // 
            this.btnLeitura3.Location = new System.Drawing.Point(243, 29);
            this.btnLeitura3.Name = "btnLeitura3";
            this.btnLeitura3.Size = new System.Drawing.Size(121, 37);
            this.btnLeitura3.TabIndex = 3;
            this.btnLeitura3.Text = "3 - Leitura";
            this.btnLeitura3.UseVisualStyleBackColor = true;
            this.btnLeitura3.Click += new System.EventHandler(this.btnLeitura3_Click);
            // 
            // btnLeitura2
            // 
            this.btnLeitura2.Location = new System.Drawing.Point(126, 29);
            this.btnLeitura2.Name = "btnLeitura2";
            this.btnLeitura2.Size = new System.Drawing.Size(111, 37);
            this.btnLeitura2.TabIndex = 2;
            this.btnLeitura2.Text = "2 - Leitura";
            this.btnLeitura2.UseVisualStyleBackColor = true;
            this.btnLeitura2.Click += new System.EventHandler(this.btnLeitura2_Click);
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(13, 29);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(107, 37);
            this.btnLeitura.TabIndex = 1;
            this.btnLeitura.Text = "1 - Leitura";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // lstLeitura
            // 
            this.lstLeitura.FormattingEnabled = true;
            this.lstLeitura.Location = new System.Drawing.Point(13, 72);
            this.lstLeitura.Name = "lstLeitura";
            this.lstLeitura.Size = new System.Drawing.Size(525, 160);
            this.lstLeitura.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.CheckPathExists = false;
            this.openFile.DefaultExt = "txt";
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "Arquivo de Texto (*.txt)|*.txt";
            this.openFile.Title = "Selecionar Arquivo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(570, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 239);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gravação de Arquivo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileGravacao
            // 
            this.openFileGravacao.FileName = "openFileGravacao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(183)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(817, 568);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNomePasta;
        private System.Windows.Forms.Button btnrenomearPasta;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.Label lblPastaAtual;
        private System.Windows.Forms.TextBox txtNomeAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeArquivoAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenomearArquivo;
        private System.Windows.Forms.TextBox txtNovoNomeArquivo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.ListBox lstLeitura;
        private System.Windows.Forms.Button btnLeitura2;
        private System.Windows.Forms.Button btnLeitura3;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileGravacao;
    }
}

