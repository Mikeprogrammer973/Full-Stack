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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Clear();
            tb_selected.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox1.Text = treeView1.SelectedNode.Tag.ToString();
            }            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(tb_selected.Text);
            /*
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "estados";
            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "cores";

            raizEstados.Nodes.Add("Santa Catarina");
            raizEstados.Nodes.Add("São Paulo");

            raizCores.Nodes.Add("Azul");
            raizCores.Nodes.Add("Laranja");
            */

            if (treeView1.SelectedNode.Nodes.Contains(node))
            {
                MessageBox.Show("Esse nó já existe!", "Duplicating Node", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treeView1.SelectedNode.Nodes.Add(tb_selected.Text);
        }
    }
}
