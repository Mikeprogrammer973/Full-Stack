
namespace aula61
{
    partial class F_main
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
            this.btn_txt = new System.Windows.Forms.Button();
            this.l_txt = new System.Windows.Forms.Label();
            this.tb_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_txt
            // 
            this.btn_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_txt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_txt.Location = new System.Drawing.Point(42, 50);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(177, 35);
            this.btn_txt.TabIndex = 0;
            this.btn_txt.Text = "Ok";
            this.btn_txt.UseVisualStyleBackColor = false;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // l_txt
            // 
            this.l_txt.AutoSize = true;
            this.l_txt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.l_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_txt.Location = new System.Drawing.Point(12, 100);
            this.l_txt.Name = "l_txt";
            this.l_txt.Size = new System.Drawing.Size(232, 20);
            this.l_txt.TabIndex = 1;
            this.l_txt.Text = "youtube.com/webhacker/cursos";
            this.l_txt.Click += new System.EventHandler(this.l_txt_Click);
            // 
            // tb_txt
            // 
            this.tb_txt.BackColor = System.Drawing.SystemColors.Info;
            this.tb_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_txt.Location = new System.Drawing.Point(42, 12);
            this.tb_txt.Name = "tb_txt";
            this.tb_txt.Size = new System.Drawing.Size(177, 20);
            this.tb_txt.TabIndex = 2;
            // 
            // F_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_txt);
            this.Controls.Add(this.l_txt);
            this.Controls.Add(this.btn_txt);
            this.Name = "F_main";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.Label l_txt;
        private System.Windows.Forms.TextBox tb_txt;
    }
}

