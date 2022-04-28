
namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_getDate = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_setDate = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(26, 19);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(318, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_getDate
            // 
            this.btn_getDate.Location = new System.Drawing.Point(350, 19);
            this.btn_getDate.Name = "btn_getDate";
            this.btn_getDate.Size = new System.Drawing.Size(97, 23);
            this.btn_getDate.TabIndex = 1;
            this.btn_getDate.Text = "Get Date";
            this.btn_getDate.UseVisualStyleBackColor = true;
            this.btn_getDate.Click += new System.EventHandler(this.btn_getDate_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(26, 49);
            this.tb_data.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(318, 20);
            this.tb_data.TabIndex = 2;
            this.tb_data.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(31, 91);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 20);
            this.tb_dia.TabIndex = 3;
            this.tb_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(137, 91);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 4;
            this.tb_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(243, 91);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 5;
            this.tb_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_setDate
            // 
            this.btn_setDate.Location = new System.Drawing.Point(349, 91);
            this.btn_setDate.Name = "btn_setDate";
            this.btn_setDate.Size = new System.Drawing.Size(167, 23);
            this.btn_setDate.TabIndex = 9;
            this.btn_setDate.Text = "Set Date";
            this.btn_setDate.UseVisualStyleBackColor = true;
            this.btn_setDate.Click += new System.EventHandler(this.btn_setDate_Click);
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(453, 20);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(63, 23);
            this.btn_today.TabIndex = 10;
            this.btn_today.Text = "Today";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_setDate);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_getDate);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_getDate;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_setDate;
        private System.Windows.Forms.Button btn_today;
    }
}