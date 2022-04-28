
namespace Componentes
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_canal = new System.Windows.Forms.LinkLabel();
            this.lb_calc = new System.Windows.Forms.LinkLabel();
            this.lb_mul_links = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o seu Nome...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lb_canal
            // 
            this.lb_canal.AutoSize = true;
            this.lb_canal.Location = new System.Drawing.Point(13, 95);
            this.lb_canal.Name = "lb_canal";
            this.lb_canal.Size = new System.Drawing.Size(58, 13);
            this.lb_canal.TabIndex = 2;
            this.lb_canal.TabStop = true;
            this.lb_canal.Text = "Mega Quiz";
            this.lb_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_canal_LinkClicked);
            // 
            // lb_calc
            // 
            this.lb_calc.AutoSize = true;
            this.lb_calc.Location = new System.Drawing.Point(90, 95);
            this.lb_calc.Name = "lb_calc";
            this.lb_calc.Size = new System.Drawing.Size(63, 13);
            this.lb_calc.TabIndex = 3;
            this.lb_calc.TabStop = true;
            this.lb_calc.Text = "Calculadora";
            this.lb_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_calc_LinkClicked);
            // 
            // lb_mul_links
            // 
            this.lb_mul_links.AutoSize = true;
            this.lb_mul_links.Location = new System.Drawing.Point(10, 164);
            this.lb_mul_links.Name = "lb_mul_links";
            this.lb_mul_links.Size = new System.Drawing.Size(126, 13);
            this.lb_mul_links.TabIndex = 4;
            this.lb_mul_links.TabStop = true;
            this.lb_mul_links.Text = "Google - Canal - Youtube";
            this.lb_mul_links.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_mul_links_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 273);
            this.Controls.Add(this.lb_mul_links);
            this.Controls.Add(this.lb_calc);
            this.Controls.Add(this.lb_canal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel lb_canal;
        private System.Windows.Forms.LinkLabel lb_calc;
        private System.Windows.Forms.LinkLabel lb_mul_links;
    }
}