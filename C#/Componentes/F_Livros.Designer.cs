
namespace Componentes
{
    partial class F_Livros
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
            this.tb_show_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_show_list
            // 
            this.tb_show_list.Location = new System.Drawing.Point(12, 12);
            this.tb_show_list.Multiline = true;
            this.tb_show_list.Name = "tb_show_list";
            this.tb_show_list.Size = new System.Drawing.Size(357, 360);
            this.tb_show_list.TabIndex = 0;
            // 
            // F_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 378);
            this.Controls.Add(this.tb_show_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Livros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Livros_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_show_list;
    }
}