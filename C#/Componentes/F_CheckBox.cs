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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> livros = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            livros.Add(cb_bible);
            livros.Add(cb_divergent);
            livros.Add(cb_eragon);
            livros.Add(cb_hpotter);
            livros.Add(cb_origem);
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(CheckBox l in livros)
            {
                if (l.Checked)
                {
                    txt += l.Text + "   ";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_origem_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_origem.Checked)
            {
                MessageBox.Show("O livro 'Origem' de Dan Brown está marcado!");
            }
        }

        private void btn_abrirF_filho_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();
            f_FilhoCheckBox.Show();
        }
    }
}
