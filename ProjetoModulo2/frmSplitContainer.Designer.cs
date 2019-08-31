namespace ProjetoModulo2
{
    partial class FrmSplitContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.lsbImagens = new System.Windows.Forms.ListBox();
            this.spcConteudo = new System.Windows.Forms.SplitContainer();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.pnlImagem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcConteudo)).BeginInit();
            this.spcConteudo.Panel1.SuspendLayout();
            this.spcConteudo.Panel2.SuspendLayout();
            this.spcConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcContainer
            // 
            this.spcContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spcContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContainer.Location = new System.Drawing.Point(0, 0);
            this.spcContainer.Name = "spcContainer";
            // 
            // spcContainer.Panel1
            // 
            this.spcContainer.Panel1.Controls.Add(this.lsbImagens);
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.Controls.Add(this.spcConteudo);
            this.spcContainer.Size = new System.Drawing.Size(800, 450);
            this.spcContainer.SplitterDistance = 140;
            this.spcContainer.TabIndex = 0;
            // 
            // lsbImagens
            // 
            this.lsbImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbImagens.FormattingEnabled = true;
            this.lsbImagens.Location = new System.Drawing.Point(0, 0);
            this.lsbImagens.Name = "lsbImagens";
            this.lsbImagens.Size = new System.Drawing.Size(136, 446);
            this.lsbImagens.TabIndex = 0;
            this.lsbImagens.SelectedIndexChanged += new System.EventHandler(this.lsbImagens_SelectedIndexChanged);
            // 
            // spcConteudo
            // 
            this.spcConteudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcConteudo.Location = new System.Drawing.Point(0, 0);
            this.spcConteudo.Name = "spcConteudo";
            this.spcConteudo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcConteudo.Panel1
            // 
            this.spcConteudo.Panel1.Controls.Add(this.lblInformacao);
            // 
            // spcConteudo.Panel2
            // 
            this.spcConteudo.Panel2.Controls.Add(this.pnlImagem);
            this.spcConteudo.Size = new System.Drawing.Size(656, 450);
            this.spcConteudo.SplitterDistance = 88;
            this.spcConteudo.TabIndex = 0;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformacao.Location = new System.Drawing.Point(0, 0);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(35, 13);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "label1";
            // 
            // pnlImagem
            // 
            this.pnlImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagem.Location = new System.Drawing.Point(0, 0);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(652, 354);
            this.pnlImagem.TabIndex = 0;
            // 
            // FrmSplitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spcContainer);
            this.Name = "FrmSplitContainer";
            this.Text = "frmSplitContainer";
            this.Load += new System.EventHandler(this.FrmSplitContainer_Load);
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.spcConteudo.Panel1.ResumeLayout(false);
            this.spcConteudo.Panel1.PerformLayout();
            this.spcConteudo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcConteudo)).EndInit();
            this.spcConteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.SplitContainer spcConteudo;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.ListBox lsbImagens;
    }
}