
namespace aula60
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
            this.btn_canal = new System.Windows.Forms.Button();
            this.lb_link_canal = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_canal
            // 
            this.btn_canal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_canal.Font = new System.Drawing.Font("Britannic Bold", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canal.Location = new System.Drawing.Point(30, 48);
            this.btn_canal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_canal.Name = "btn_canal";
            this.btn_canal.Size = new System.Drawing.Size(228, 37);
            this.btn_canal.TabIndex = 0;
            this.btn_canal.Text = "Web Hacker";
            this.btn_canal.UseVisualStyleBackColor = false;
            // 
            // lb_link_canal
            // 
            this.lb_link_canal.AutoSize = true;
            this.lb_link_canal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_link_canal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_link_canal.Location = new System.Drawing.Point(26, 22);
            this.lb_link_canal.Name = "lb_link_canal";
            this.lb_link_canal.Size = new System.Drawing.Size(232, 20);
            this.lb_link_canal.TabIndex = 1;
            this.lb_link_canal.Text = "youtube.com/webhacker/cursos";
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_nome.Font = new System.Drawing.Font("Kokila", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_nome.Location = new System.Drawing.Point(30, 94);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(228, 27);
            this.tb_nome.TabIndex = 2;
            this.tb_nome.Text = "Mike D. Pascal";
            this.tb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(392, 487);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_link_canal);
            this.Controls.Add(this.btn_canal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_canal;
        private System.Windows.Forms.Label lb_link_canal;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

