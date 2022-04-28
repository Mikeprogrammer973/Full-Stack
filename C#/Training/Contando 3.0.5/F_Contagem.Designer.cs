
namespace Contando_3._0._5
{
    partial class F_Contagem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contagemPersonalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesDeContagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_contagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contagemPersonalizadaToolStripMenuItem,
            this.opçõesDeContagemToolStripMenuItem});
            this.voltarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.voltarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // contagemPersonalizadaToolStripMenuItem
            // 
            this.contagemPersonalizadaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contagemPersonalizadaToolStripMenuItem.Name = "contagemPersonalizadaToolStripMenuItem";
            this.contagemPersonalizadaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.contagemPersonalizadaToolStripMenuItem.Text = "Contagem Personalizada";
            this.contagemPersonalizadaToolStripMenuItem.Click += new System.EventHandler(this.contagemPersonalizadaToolStripMenuItem_Click);
            // 
            // opçõesDeContagemToolStripMenuItem
            // 
            this.opçõesDeContagemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.opçõesDeContagemToolStripMenuItem.Name = "opçõesDeContagemToolStripMenuItem";
            this.opçõesDeContagemToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.opçõesDeContagemToolStripMenuItem.Text = "Opções de Contagem";
            this.opçõesDeContagemToolStripMenuItem.Click += new System.EventHandler(this.opçõesDeContagemToolStripMenuItem_Click);
            // 
            // tb_contagem
            // 
            this.tb_contagem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_contagem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contagem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_contagem.Location = new System.Drawing.Point(12, 87);
            this.tb_contagem.Multiline = true;
            this.tb_contagem.Name = "tb_contagem";
            this.tb_contagem.ReadOnly = true;
            this.tb_contagem.Size = new System.Drawing.Size(435, 387);
            this.tb_contagem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contagem:";
            // 
            // F_Contagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_contagem);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Contagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contando 3.0.5 - Contagem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contagemPersonalizadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesDeContagemToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_contagem;
        private System.Windows.Forms.Label label1;
    }
}