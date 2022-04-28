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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void focar(TextBox tb)
        {
            tb.Clear();
            tb.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "" || tb_product.Text == "" || tb_qtd.Text == "" || tb_preco.Text == "")
            {
                MessageBox.Show("Dados inválidos, verifique-os e tente novamente!");
            }
            else
            {
                string[] product = new string[4];
                product[0] = tb_id.Text;
                product[1] = tb_product.Text;
                product[2] = tb_qtd.Text;
                product[3] = tb_preco.Text;

                ListViewItem l = new ListViewItem(product);

                lv_products.Items.Add(l);

                focar(tb_product);
                focar(tb_qtd);
                focar(tb_preco);
                focar(tb_id);
            }            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lv_products.Items.RemoveAt(lv_products.SelectedIndices[0]);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_products.SelectedItems[0].SubItems[0].Text;
            tb_product.Text = lv_products.SelectedItems[0].SubItems[1].Text;
            tb_qtd.Text = lv_products.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_products.SelectedItems[0].SubItems[3].Text;
        }

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_products.SelectedIndices.Count > 0){
                tb_id.Text = lv_products.Items[lv_products.SelectedIndices[0]].SubItems[0].Text;
                tb_product.Text = lv_products.Items[lv_products.SelectedIndices[0]].SubItems[1].Text;
                tb_qtd.Text = lv_products.Items[lv_products.SelectedIndices[0]].SubItems[2].Text;
                tb_preco.Text = lv_products.Items[lv_products.SelectedIndices[0]].SubItems[3].Text;
            }           
        }
    }
}
