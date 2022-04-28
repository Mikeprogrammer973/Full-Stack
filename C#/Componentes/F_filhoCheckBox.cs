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
    public partial class F_filhoCheckBox : Form
    {
        public F_CheckBox f_CheckBox;
        public F_filhoCheckBox()
        {
            InitializeComponent();

            try
            {
                f_CheckBox = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_bible.Checked = f_CheckBox.cb_bible.Checked;
                cb_divergent.Checked = f_CheckBox.cb_divergent.Checked;
                cb_eragon.Checked = f_CheckBox.cb_eragon.Checked;
                cb_hpotter.Checked = f_CheckBox.cb_hpotter.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o formulário!");
            }            
        }

        private void cb_bible_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_bible.Checked = cb_bible.Checked;
        }

        private void cb_hpotter_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_hpotter.Checked = cb_hpotter.Checked;
        }

        private void cb_eragon_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_eragon.Checked = cb_eragon.Checked;
        }

        private void cb_divergent_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_divergent.Checked = cb_divergent.Checked;
        }
    }
}
