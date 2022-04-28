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
    public partial class F_ListBox : Form
    {
        List<String> livros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            livros.Add("A Seca");
            livros.Add("Ponto de Impacto");
            livros.Add("Apollo");
            livros.Add("Divergente");

            lb_livros.DataSource = livros;
        }

        public void update(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        public void focar(TextBox tb)
        {
            tb.Clear();
            tb.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_livro.Text == "")
            {
                MessageBox.Show("Digite o nome do livro para adicioná-lo!");
                tb_livro.Focus();
            }
            else
            {
                if (livros.Contains(tb_livro.Text))
                {
                    MessageBox.Show("Esse livro já foi adicionado!");
                    focar(tb_livro);
                }
                else
                {
                    livros.Add(tb_livro.Text);
                    update(lb_livros, livros);
                    focar(tb_livro);
                }               
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            livros.RemoveAt(lb_livros.SelectedIndex);
            update(lb_livros, livros);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            tb_livro.Text = livros[lb_livros.SelectedIndex];
            MessageBox.Show(livros[lb_livros.SelectedIndex]);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            livros.Clear();
            update(lb_livros, livros);
            tb_livro.Focus();
        }
    }
}
