
namespace Contando_3._0._5
{
    partial class F_Config
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesDeContagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_init = new System.Windows.Forms.TextBox();
            this.tb_fim = new System.Windows.Forms.TextBox();
            this.tb_passo = new System.Windows.Forms.TextBox();
            this.btn_contar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesDeContagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesDeContagensToolStripMenuItem
            // 
            this.opçõesDeContagensToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.opçõesDeContagensToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.opçõesDeContagensToolStripMenuItem.Name = "opçõesDeContagensToolStripMenuItem";
            this.opçõesDeContagensToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.opçõesDeContagensToolStripMenuItem.Text = "Opções de Contagens";
            this.opçõesDeContagensToolStripMenuItem.Click += new System.EventHandler(this.opçõesDeContagensToolStripMenuItem_Click);
            // 
            // tb_init
            // 
            this.tb_init.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_init.Location = new System.Drawing.Point(16, 70);
            this.tb_init.Name = "tb_init";
            this.tb_init.Size = new System.Drawing.Size(160, 23);
            this.tb_init.TabIndex = 1;
            this.tb_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fim
            // 
            this.tb_fim.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fim.Location = new System.Drawing.Point(16, 131);
            this.tb_fim.Name = "tb_fim";
            this.tb_fim.Size = new System.Drawing.Size(160, 23);
            this.tb_fim.TabIndex = 2;
            this.tb_fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_passo
            // 
            this.tb_passo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_passo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passo.Location = new System.Drawing.Point(16, 196);
            this.tb_passo.Name = "tb_passo";
            this.tb_passo.Size = new System.Drawing.Size(160, 23);
            this.tb_passo.TabIndex = 3;
            this.tb_passo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_contar
            // 
            this.btn_contar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_contar.Location = new System.Drawing.Point(17, 257);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(159, 32);
            this.btn_contar.TabIndex = 4;
            this.btn_contar.Text = "Contar";
            this.btn_contar.UseVisualStyleBackColor = false;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Passo:";
            // 
            // F_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.tb_passo);
            this.Controls.Add(this.tb_fim);
            this.Controls.Add(this.tb_init);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contando 3.0.5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesDeContagensToolStripMenuItem;
        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_init;
        public System.Windows.Forms.TextBox tb_fim;
        public System.Windows.Forms.TextBox tb_passo;
    }
}

