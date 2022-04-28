
namespace Componentes
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_elmts = new System.Windows.Forms.TabPage();
            this.tab_more = new System.Windows.Forms.TabPage();
            this.tb_newPageName = new System.Windows.Forms.TextBox();
            this.btn_addPage = new System.Windows.Forms.Button();
            this.btn_removePage = new System.Windows.Forms.Button();
            this.nud_navegar = new System.Windows.Forms.NumericUpDown();
            this.btn_goto = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tab_elmts.SuspendLayout();
            this.tab_more.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_navegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_elmts);
            this.tabControl1.Controls.Add(this.tab_more);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_elmts
            // 
            this.tab_elmts.Controls.Add(this.splitContainer1);
            this.tab_elmts.Location = new System.Drawing.Point(4, 22);
            this.tab_elmts.Name = "tab_elmts";
            this.tab_elmts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_elmts.Size = new System.Drawing.Size(571, 258);
            this.tab_elmts.TabIndex = 0;
            this.tab_elmts.Text = "Elements";
            this.tab_elmts.UseVisualStyleBackColor = true;
            // 
            // tab_more
            // 
            this.tab_more.Controls.Add(this.splitContainer2);
            this.tab_more.Location = new System.Drawing.Point(4, 22);
            this.tab_more.Name = "tab_more";
            this.tab_more.Padding = new System.Windows.Forms.Padding(3);
            this.tab_more.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_more.Size = new System.Drawing.Size(571, 258);
            this.tab_more.TabIndex = 1;
            this.tab_more.Text = "More...";
            this.tab_more.UseVisualStyleBackColor = true;
            // 
            // tb_newPageName
            // 
            this.tb_newPageName.Location = new System.Drawing.Point(13, 13);
            this.tb_newPageName.Name = "tb_newPageName";
            this.tb_newPageName.Size = new System.Drawing.Size(123, 20);
            this.tb_newPageName.TabIndex = 1;
            // 
            // btn_addPage
            // 
            this.btn_addPage.Location = new System.Drawing.Point(143, 9);
            this.btn_addPage.Name = "btn_addPage";
            this.btn_addPage.Size = new System.Drawing.Size(125, 23);
            this.btn_addPage.TabIndex = 2;
            this.btn_addPage.Text = "Adicionar";
            this.btn_addPage.UseVisualStyleBackColor = true;
            this.btn_addPage.Click += new System.EventHandler(this.btn_addPage_Click);
            // 
            // btn_removePage
            // 
            this.btn_removePage.Location = new System.Drawing.Point(275, 8);
            this.btn_removePage.Name = "btn_removePage";
            this.btn_removePage.Size = new System.Drawing.Size(108, 23);
            this.btn_removePage.TabIndex = 3;
            this.btn_removePage.Text = "Remover";
            this.btn_removePage.UseVisualStyleBackColor = true;
            this.btn_removePage.Click += new System.EventHandler(this.btn_removePage_Click);
            // 
            // nud_navegar
            // 
            this.nud_navegar.Location = new System.Drawing.Point(13, 40);
            this.nud_navegar.Name = "nud_navegar";
            this.nud_navegar.ReadOnly = true;
            this.nud_navegar.Size = new System.Drawing.Size(120, 20);
            this.nud_navegar.TabIndex = 4;
            this.nud_navegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_goto
            // 
            this.btn_goto.Location = new System.Drawing.Point(143, 40);
            this.btn_goto.Name = "btn_goto";
            this.btn_goto.Size = new System.Drawing.Size(240, 23);
            this.btn_goto.TabIndex = 5;
            this.btn_goto.Text = "Posicianar";
            this.btn_goto.UseVisualStyleBackColor = true;
            this.btn_goto.Click += new System.EventHandler(this.btn_goto_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Size = new System.Drawing.Size(565, 252);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(565, 252);
            this.splitContainer2.SplitterDistance = 115;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(446, 252);
            this.splitContainer3.SplitterDistance = 206;
            this.splitContainer3.TabIndex = 0;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 350);
            this.Controls.Add(this.btn_goto);
            this.Controls.Add(this.nud_navegar);
            this.Controls.Add(this.btn_removePage);
            this.Controls.Add(this.btn_addPage);
            this.Controls.Add(this.tb_newPageName);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "TabControl";
            this.tabControl1.ResumeLayout(false);
            this.tab_elmts.ResumeLayout(false);
            this.tab_more.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_navegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_elmts;
        private System.Windows.Forms.TabPage tab_more;
        private System.Windows.Forms.TextBox tb_newPageName;
        private System.Windows.Forms.Button btn_addPage;
        private System.Windows.Forms.Button btn_removePage;
        private System.Windows.Forms.NumericUpDown nud_navegar;
        private System.Windows.Forms.Button btn_goto;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}