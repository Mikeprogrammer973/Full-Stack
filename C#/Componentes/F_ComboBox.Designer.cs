
namespace Componentes
{
    partial class F_ComboBox
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
            this.cbb_livros = new System.Windows.Forms.ComboBox();
            this.btn_selected = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_addbook = new System.Windows.Forms.Button();
            this.tb_addbook = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_livros
            // 
            this.cbb_livros.FormattingEnabled = true;
            this.cbb_livros.Items.AddRange(new object[] {
            "Bíblia Sagrada",
            "Infinity Hope",
            "A Seca",
            "Os Filhos de Anansi",
            "Anjo e Demônio"});
            this.cbb_livros.Location = new System.Drawing.Point(19, 21);
            this.cbb_livros.Name = "cbb_livros";
            this.cbb_livros.Size = new System.Drawing.Size(209, 21);
            this.cbb_livros.TabIndex = 0;
            this.cbb_livros.Text = "Bíblia Sagrada";
            this.cbb_livros.SelectedIndexChanged += new System.EventHandler(this.cbb_livros_SelectedIndexChanged);
            // 
            // btn_selected
            // 
            this.btn_selected.Location = new System.Drawing.Point(234, 21);
            this.btn_selected.Name = "btn_selected";
            this.btn_selected.Size = new System.Drawing.Size(237, 23);
            this.btn_selected.TabIndex = 1;
            this.btn_selected.Text = "Selecionado";
            this.btn_selected.UseVisualStyleBackColor = true;
            this.btn_selected.Click += new System.EventHandler(this.btn_selected_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(234, 50);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(237, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar Elementos";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_addbook
            // 
            this.btn_addbook.Location = new System.Drawing.Point(234, 161);
            this.btn_addbook.Name = "btn_addbook";
            this.btn_addbook.Size = new System.Drawing.Size(237, 23);
            this.btn_addbook.TabIndex = 3;
            this.btn_addbook.Text = "Adicionar";
            this.btn_addbook.UseVisualStyleBackColor = true;
            this.btn_addbook.Click += new System.EventHandler(this.btn_addbook_Click);
            // 
            // tb_addbook
            // 
            this.tb_addbook.Location = new System.Drawing.Point(234, 135);
            this.tb_addbook.Name = "tb_addbook";
            this.tb_addbook.Size = new System.Drawing.Size(237, 20);
            this.tb_addbook.TabIndex = 4;
            this.tb_addbook.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(234, 83);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(237, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Resetar Elementos";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicionar Novo Livro...";
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_addbook);
            this.Controls.Add(this.btn_addbook);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_selected);
            this.Controls.Add(this.cbb_livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_livros;
        private System.Windows.Forms.Button btn_selected;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_addbook;
        private System.Windows.Forms.TextBox tb_addbook;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
    }
}