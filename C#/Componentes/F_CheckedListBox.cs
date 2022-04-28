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
    public partial class F_CheckedListBox : Form
    {
        //public string[] livros;
        public F_CheckedListBox()
        {
            InitializeComponent();
            //livros[0] = clb_livros.Items[0].ToString();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            int qtd = clb_livros.CheckedItems.Count;

            for(int c = 0; c < qtd; c++)
            {
                txt += clb_livros.CheckedItems[c] + "  ";
            }

            MessageBox.Show(txt);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clb_livros.Items.Clear();
            /*object livro = "Bíblia Sagrada";
            clb_livros.Items.Add("O Código da Vinte", false);
            clb_livros.Items.Add("O Símbolo Perdido", false);
            clb_livros.Items.Add("O Labirinto", false);
            clb_livros.Items.Add("A Bíblia Hacker", false);
            clb_livros.Items.Add("A Seca", false);
            clb_livros.Items.Add(livro, true);*/

            List<string> books = new List<string>();

            books.Add("O Código da Vinte");
            books.Add("O Símbolo Perdido");
            books.Add("O Labirinto");
            books.Add("A Bíblia Hacker");
            books.Add("A Seca");
            books.Add("Bíblia Sagrada");

            clb_livros.Items.AddRange(books.ToArray());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clb_livros.Items.Clear();
        }

        private void btn_addLivro_Click(object sender, EventArgs e)
        {
            if(tb_addLivro.Text == "")
            {
                MessageBox.Show("Digite o nome do livro para adicioná-lo!");
                tb_addLivro.Focus();
            }
            else
            {
                clb_livros.Items.Add(tb_addLivro.Text);
                tb_addLivro.Clear();
                tb_addLivro.Focus();
            }
            
        }
    }
}
