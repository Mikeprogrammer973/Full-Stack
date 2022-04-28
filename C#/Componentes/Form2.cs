using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
            nud_navegar.Maximum = tabControl1.TabPages.Count-1;
            nud_navegar.Value = tabControl1.SelectedIndex;
        }

        private void btn_addPage_Click(object sender, EventArgs e)
        {
            if(tb_newPageName.Text != "")
            {
                TabPage page = new TabPage();
                page.Text = tb_newPageName.Text;
                page.Name = tb_newPageName.Text;
                page.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(page);
                nud_navegar.Maximum = tabControl1.TabPages.Count - 1;
                tb_newPageName.Clear();
                tb_newPageName.Focus();
            }
        }

        private void btn_removePage_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            nud_navegar.Maximum = tabControl1.TabPages.Count - 1;
        }

        private void btn_goto_Click(object sender, EventArgs e)
        {            
            tabControl1.SelectedIndex = int.Parse(nud_navegar.Value.ToString());
        }
    }
}
