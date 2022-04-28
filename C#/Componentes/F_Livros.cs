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
    public partial class F_Livros : Form
    {
        F_main fm;
        public F_Livros(String book, F_main f)
        {
            InitializeComponent();
            tb_show_list.Text = book;

            fm = f;

            f.num = 7;
        }

        private void F_Livros_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.tb_lista.Text = tb_show_list.Text;
        }
    }
}
