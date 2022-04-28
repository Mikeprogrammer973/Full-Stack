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
    public partial class F_ToolStripContainer : Form
    {
        public F_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void F_ToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> ts = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;
            for(int c = 0; c < num; c++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[c].Name);
                checkedListBox1.SetItemChecked(c, true);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = checkedListBox1.Items.Count;

            for(int c = 0; c < num; c++)
            {
                if (checkedListBox1.GetItemChecked(c))
                {
                    toolStripContainer1.TopToolStripPanel.Controls[c].Visible = true;
                }
                else
                {
                    toolStripContainer1.TopToolStripPanel.Controls[c].Visible = false;
                }
            }            
        }
    }
}
