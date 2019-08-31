namespace ProjetoModulo2
{
    partial class FrmTabelLayoutPanel
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
            this.tlpTabelaConteiner = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpTabelaConteiner
            // 
            this.tlpTabelaConteiner.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTabelaConteiner.ColumnCount = 3;
            this.tlpTabelaConteiner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTabelaConteiner.Location = new System.Drawing.Point(0, 0);
            this.tlpTabelaConteiner.Name = "tlpTabelaConteiner";
            this.tlpTabelaConteiner.RowCount = 3;
            this.tlpTabelaConteiner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTabelaConteiner.Size = new System.Drawing.Size(802, 447);
            this.tlpTabelaConteiner.TabIndex = 1;
            // 
            // FrmTabelLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 447);
            this.Controls.Add(this.tlpTabelaConteiner);
            this.Name = "FrmTabelLayoutPanel";
            this.Text = "FrmTabelLayoutPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTabelaConteiner;
    }
}