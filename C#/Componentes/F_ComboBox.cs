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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_selected_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbb_livros.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cbb_livros.Text = "";
            cbb_livros.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();

            l.Add("Bíblia Sagrada");
            l.Add("Infinity Hope");
            l.Add("A Seca");
            l.Add("Os Filhos de Anansi");
            l.Add("Anjo e Demônio");

            cbb_livros.Items.Clear();

            cbb_livros.Text = "Bíblia Sagrada";
            cbb_livros.Items.AddRange(l.ToArray());
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            if(tb_addbook.Text != "")
            {
                if(cbb_livros.FindString(tb_addbook.Text) < 0)
                {
                    cbb_livros.Items.Add(tb_addbook.Text);
                    tb_addbook.Clear();
                    tb_addbook.Focus();
                }
                else
                {
                    MessageBox.Show("Esse Elemento já existe!");
                }
                
            }
            else
            {
                MessageBox.Show("Digite o nome do livro para adiocioná-lo!");
                tb_addbook.Focus();
            }
        }

        private void cbb_livros_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_addbook.Text = cbb_livros.Text;
        }
    }
}
