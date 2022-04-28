
namespace Componentes
{
    partial class F_filhoCheckBox
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
            this.cb_divergent = new System.Windows.Forms.CheckBox();
            this.cb_eragon = new System.Windows.Forms.CheckBox();
            this.cb_hpotter = new System.Windows.Forms.CheckBox();
            this.cb_bible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_divergent
            // 
            this.cb_divergent.AutoSize = true;
            this.cb_divergent.Location = new System.Drawing.Point(12, 84);
            this.cb_divergent.Name = "cb_divergent";
            this.cb_divergent.Size = new System.Drawing.Size(72, 17);
            this.cb_divergent.TabIndex = 7;
            this.cb_divergent.Text = "Divergent";
            this.cb_divergent.UseVisualStyleBackColor = true;
            this.cb_divergent.CheckedChanged += new System.EventHandler(this.cb_divergent_CheckedChanged);
            // 
            // cb_eragon
            // 
            this.cb_eragon.AutoSize = true;
            this.cb_eragon.Location = new System.Drawing.Point(12, 60);
            this.cb_eragon.Name = "cb_eragon";
            this.cb_eragon.Size = new System.Drawing.Size(60, 17);
            this.cb_eragon.TabIndex = 6;
            this.cb_eragon.Text = "Eragon";
            this.cb_eragon.UseVisualStyleBackColor = true;
            this.cb_eragon.CheckedChanged += new System.EventHandler(this.cb_eragon_CheckedChanged);
            // 
            // cb_hpotter
            // 
            this.cb_hpotter.AutoSize = true;
            this.cb_hpotter.Location = new System.Drawing.Point(12, 36);
            this.cb_hpotter.Name = "cb_hpotter";
            this.cb_hpotter.Size = new System.Drawing.Size(82, 17);
            this.cb_hpotter.TabIndex = 5;
            this.cb_hpotter.Text = "Harry Potter";
            this.cb_hpotter.UseVisualStyleBackColor = true;
            this.cb_hpotter.CheckedChanged += new System.EventHandler(this.cb_hpotter_CheckedChanged);
            // 
            // cb_bible
            // 
            this.cb_bible.AutoSize = true;
            this.cb_bible.Location = new System.Drawing.Point(12, 12);
            this.cb_bible.Name = "cb_bible";
            this.cb_bible.Size = new System.Drawing.Size(73, 17);
            this.cb_bible.TabIndex = 4;
            this.cb_bible.Text = "Holy Bible";
            this.cb_bible.UseVisualStyleBackColor = true;
            this.cb_bible.CheckedChanged += new System.EventHandler(this.cb_bible_CheckedChanged);
            // 
            // F_filhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 159);
            this.Controls.Add(this.cb_divergent);
            this.Controls.Add(this.cb_eragon);
            this.Controls.Add(this.cb_hpotter);
            this.Controls.Add(this.cb_bible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_filhoCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_divergent;
        private System.Windows.Forms.CheckBox cb_eragon;
        private System.Windows.Forms.CheckBox cb_hpotter;
        private System.Windows.Forms.CheckBox cb_bible;
    }
}