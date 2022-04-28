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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            String msg = mtb_cpf.Text;
            MessageBox.Show(msg);

        }

        private void cb_reveal_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_reveal.Checked)
            {
                mtb_senha.PasswordChar = '*';
            }
            else
            {
                MessageBox.Show(mtb_senha.Text);
            }        
        }
    }
}
