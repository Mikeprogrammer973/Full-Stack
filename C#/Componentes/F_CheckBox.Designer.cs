
namespace Componentes
{
    partial class F_CheckBox
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
            this.cb_bible = new System.Windows.Forms.CheckBox();
            this.cb_hpotter = new System.Windows.Forms.CheckBox();
            this.cb_eragon = new System.Windows.Forms.CheckBox();
            this.cb_divergent = new System.Windows.Forms.CheckBox();
            this.btn_verify = new System.Windows.Forms.Button();
            this.cb_origem = new System.Windows.Forms.CheckBox();
            this.btn_abrirF_filho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_bible
            // 
            this.cb_bible.AutoSize = true;
            this.cb_bible.Location = new System.Drawing.Point(13, 13);
            this.cb_bible.Name = "cb_bible";
            this.cb_bible.Size = new System.Drawing.Size(73, 17);
            this.cb_bible.TabIndex = 0;
            this.cb_bible.Text = "Holy Bible";
            this.cb_bible.UseVisualStyleBackColor = true;
            // 
            // cb_hpotter
            // 
            this.cb_hpotter.AutoSize = true;
            this.cb_hpotter.Location = new System.Drawing.Point(13, 37);
            this.cb_hpotter.Name = "cb_hpotter";
            this.cb_hpotter.Size = new System.Drawing.Size(82, 17);
            this.cb_hpotter.TabIndex = 1;
            this.cb_hpotter.Text = "Harry Potter";
            this.cb_hpotter.UseVisualStyleBackColor = true;
            // 
            // cb_eragon
            // 
            this.cb_eragon.AutoSize = true;
            this.cb_eragon.Location = new System.Drawing.Point(13, 61);
            this.cb_eragon.Name = "cb_eragon";
            this.cb_eragon.Size = new System.Drawing.Size(60, 17);
            this.cb_eragon.TabIndex = 2;
            this.cb_eragon.Text = "Eragon";
            this.cb_eragon.UseVisualStyleBackColor = true;
            // 
            // cb_divergent
            // 
            this.cb_divergent.AutoSize = true;
            this.cb_divergent.Location = new System.Drawing.Point(13, 85);
            this.cb_divergent.Name = "cb_divergent";
            this.cb_divergent.Size = new System.Drawing.Size(72, 17);
            this.cb_divergent.TabIndex = 3;
            this.cb_divergent.Text = "Divergent";
            this.cb_divergent.UseVisualStyleBackColor = true;
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(127, 13);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(152, 23);
            this.btn_verify.TabIndex = 4;
            this.btn_verify.Text = "Livros marcados";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // cb_origem
            // 
            this.cb_origem.AutoSize = true;
            this.cb_origem.Location = new System.Drawing.Point(13, 149);
            this.cb_origem.Name = "cb_origem";
            this.cb_origem.Size = new System.Drawing.Size(59, 17);
            this.cb_origem.TabIndex = 5;
            this.cb_origem.Text = "Origem";
            this.cb_origem.UseVisualStyleBackColor = true;
            this.cb_origem.CheckedChanged += new System.EventHandler(this.cb_origem_CheckedChanged);
            // 
            // btn_abrirF_filho
            // 
            this.btn_abrirF_filho.Location = new System.Drawing.Point(127, 52);
            this.btn_abrirF_filho.Name = "btn_abrirF_filho";
            this.btn_abrirF_filho.Size = new System.Drawing.Size(152, 23);
            this.btn_abrirF_filho.TabIndex = 6;
            this.btn_abrirF_filho.Text = "Abrir F_filho";
            this.btn_abrirF_filho.UseVisualStyleBackColor = true;
            this.btn_abrirF_filho.Click += new System.EventHandler(this.btn_abrirF_filho_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.btn_abrirF_filho);
            this.Controls.Add(this.cb_origem);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.cb_divergent);
            this.Controls.Add(this.cb_eragon);
            this.Controls.Add(this.cb_hpotter);
            this.Controls.Add(this.cb_bible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CkeckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.CheckBox cb_origem;
        public System.Windows.Forms.CheckBox cb_bible;
        public System.Windows.Forms.CheckBox cb_hpotter;
        public System.Windows.Forms.CheckBox cb_eragon;
        public System.Windows.Forms.CheckBox cb_divergent;
        private System.Windows.Forms.Button btn_abrirF_filho;
    }
}