
namespace Contando_3._0._5
{
    partial class F_OpContagem
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
            this.contagemPersonalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbb_init = new System.Windows.Forms.ComboBox();
            this.cbb_fim = new System.Windows.Forms.ComboBox();
            this.cbb_passo = new System.Windows.Forms.ComboBox();
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
            this.contagemPersonalizadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contagemPersonalizadaToolStripMenuItem
            // 
            this.contagemPersonalizadaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.contagemPersonalizadaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contagemPersonalizadaToolStripMenuItem.Name = "contagemPersonalizadaToolStripMenuItem";
            this.contagemPersonalizadaToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.contagemPersonalizadaToolStripMenuItem.Text = "Contagem Personalizada";
            this.contagemPersonalizadaToolStripMenuItem.Click += new System.EventHandler(this.contagemPersonalizadaToolStripMenuItem_Click);
            // 
            // cbb_init
            // 
            this.cbb_init.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbb_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_init.FormattingEnabled = true;
            this.cbb_init.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "900",
            "800",
            "1000",
            "-1000",
            "-900",
            "-800",
            "-700",
            "-600",
            "-500",
            "-400",
            "-300",
            "-200",
            "-100"});
            this.cbb_init.Location = new System.Drawing.Point(13, 64);
            this.cbb_init.Name = "cbb_init";
            this.cbb_init.Size = new System.Drawing.Size(121, 24);
            this.cbb_init.TabIndex = 1;
            // 
            // cbb_fim
            // 
            this.cbb_fim.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fim.FormattingEnabled = true;
            this.cbb_fim.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "900",
            "800",
            "1000",
            "-1000",
            "-900",
            "-800",
            "-700",
            "-600",
            "-500",
            "-400",
            "-300",
            "-200",
            "-100"});
            this.cbb_fim.Location = new System.Drawing.Point(13, 135);
            this.cbb_fim.Name = "cbb_fim";
            this.cbb_fim.Size = new System.Drawing.Size(121, 24);
            this.cbb_fim.TabIndex = 2;
            // 
            // cbb_passo
            // 
            this.cbb_passo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbb_passo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_passo.FormattingEnabled = true;
            this.cbb_passo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "17",
            "19",
            "20",
            "45",
            "65",
            "100",
            "129"});
            this.cbb_passo.Location = new System.Drawing.Point(13, 206);
            this.cbb_passo.Name = "cbb_passo";
            this.cbb_passo.Size = new System.Drawing.Size(121, 24);
            this.cbb_passo.TabIndex = 3;
            // 
            // btn_contar
            // 
            this.btn_contar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_contar.Location = new System.Drawing.Point(13, 262);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(121, 28);
            this.btn_contar.TabIndex = 4;
            this.btn_contar.Text = "Contar";
            this.btn_contar.UseVisualStyleBackColor = false;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Passo:";
            // 
            // F_OpContagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.cbb_passo);
            this.Controls.Add(this.cbb_fim);
            this.Controls.Add(this.cbb_init);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_OpContagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contando 3.0.5 - Opções de Contagem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contagemPersonalizadaToolStripMenuItem;
        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbb_init;
        public System.Windows.Forms.ComboBox cbb_fim;
        public System.Windows.Forms.ComboBox cbb_passo;
    }
}