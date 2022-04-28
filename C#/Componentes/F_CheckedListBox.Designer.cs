
namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_livros = new System.Windows.Forms.CheckedListBox();
            this.btn_selecionados = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tb_addLivro = new System.Windows.Forms.TextBox();
            this.btn_addLivro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_livros
            // 
            this.clb_livros.FormattingEnabled = true;
            this.clb_livros.Items.AddRange(new object[] {
            "O Código da Vinte",
            "O Símbolo Perdido",
            "O Labirinto",
            "A Bíblia Hacker",
            "A Seca",
            "Bíblia Sagrada"});
            this.clb_livros.Location = new System.Drawing.Point(17, 24);
            this.clb_livros.Name = "clb_livros";
            this.clb_livros.Size = new System.Drawing.Size(291, 199);
            this.clb_livros.TabIndex = 0;
            // 
            // btn_selecionados
            // 
            this.btn_selecionados.Location = new System.Drawing.Point(315, 24);
            this.btn_selecionados.Name = "btn_selecionados";
            this.btn_selecionados.Size = new System.Drawing.Size(133, 23);
            this.btn_selecionados.TabIndex = 1;
            this.btn_selecionados.Text = "Selecionados";
            this.btn_selecionados.UseVisualStyleBackColor = true;
            this.btn_selecionados.Click += new System.EventHandler(this.btn_selecionados_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(315, 53);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar Lista";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(314, 82);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Resetar Lista";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tb_addLivro
            // 
            this.tb_addLivro.Location = new System.Drawing.Point(17, 252);
            this.tb_addLivro.Name = "tb_addLivro";
            this.tb_addLivro.Size = new System.Drawing.Size(152, 20);
            this.tb_addLivro.TabIndex = 4;
            // 
            // btn_addLivro
            // 
            this.btn_addLivro.Location = new System.Drawing.Point(175, 249);
            this.btn_addLivro.Name = "btn_addLivro";
            this.btn_addLivro.Size = new System.Drawing.Size(133, 23);
            this.btn_addLivro.TabIndex = 5;
            this.btn_addLivro.Text = "Adicionar Livro";
            this.btn_addLivro.UseVisualStyleBackColor = true;
            this.btn_addLivro.Click += new System.EventHandler(this.btn_addLivro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicionar um novo Livro...";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addLivro);
            this.Controls.Add(this.tb_addLivro);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_selecionados);
            this.Controls.Add(this.clb_livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_livros;
        private System.Windows.Forms.Button btn_selecionados;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tb_addLivro;
        private System.Windows.Forms.Button btn_addLivro;
        private System.Windows.Forms.Label label1;
    }
}