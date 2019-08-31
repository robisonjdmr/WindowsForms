namespace ProjetoModulo2
{
    partial class FrmFlowLayoutPainel
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
            this.btnFormTabelLayoutPanel = new System.Windows.Forms.Button();
            this.btnTabControl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFormPainel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.frpConteiner = new System.Windows.Forms.FlowLayoutPanel();
            this.frpConteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormTabelLayoutPanel
            // 
            this.btnFormTabelLayoutPanel.Location = new System.Drawing.Point(344, 3);
            this.btnFormTabelLayoutPanel.Name = "btnFormTabelLayoutPanel";
            this.btnFormTabelLayoutPanel.Size = new System.Drawing.Size(94, 42);
            this.btnFormTabelLayoutPanel.TabIndex = 4;
            this.btnFormTabelLayoutPanel.Text = "Abre form Tabel Layout Panel";
            this.btnFormTabelLayoutPanel.UseVisualStyleBackColor = true;
            this.btnFormTabelLayoutPanel.Click += new System.EventHandler(this.btnFormTabelLayoutPanel_Click);
            // 
            // btnTabControl
            // 
            this.btnTabControl.Location = new System.Drawing.Point(263, 3);
            this.btnTabControl.Name = "btnTabControl";
            this.btnTabControl.Size = new System.Drawing.Size(75, 42);
            this.btnTabControl.TabIndex = 3;
            this.btnTabControl.Text = "Abre Form TabControl";
            this.btnTabControl.UseVisualStyleBackColor = true;
            this.btnTabControl.Click += new System.EventHandler(this.btnTabControl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Abre form Split Container";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFormSplitContainer_Click);
            // 
            // btnFormPainel
            // 
            this.btnFormPainel.Location = new System.Drawing.Point(84, 3);
            this.btnFormPainel.Name = "btnFormPainel";
            this.btnFormPainel.Size = new System.Drawing.Size(75, 42);
            this.btnFormPainel.TabIndex = 1;
            this.btnFormPainel.Text = "Abre form Painel";
            this.btnFormPainel.UseVisualStyleBackColor = true;
            this.btnFormPainel.Click += new System.EventHandler(this.btnFormPainel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abre Form GroupB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frpConteiner
            // 
            this.frpConteiner.Controls.Add(this.button1);
            this.frpConteiner.Controls.Add(this.btnFormPainel);
            this.frpConteiner.Controls.Add(this.button3);
            this.frpConteiner.Controls.Add(this.btnTabControl);
            this.frpConteiner.Controls.Add(this.btnFormTabelLayoutPanel);
            this.frpConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frpConteiner.Location = new System.Drawing.Point(0, 0);
            this.frpConteiner.Name = "frpConteiner";
            this.frpConteiner.Size = new System.Drawing.Size(744, 447);
            this.frpConteiner.TabIndex = 0;
            // 
            // frmFlowLayoutPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.frpConteiner);
            this.Name = "frmFlowLayoutPainel";
            this.Text = "Form1";
            this.frpConteiner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormTabelLayoutPanel;
        private System.Windows.Forms.Button btnTabControl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFormPainel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel frpConteiner;
    }
}

