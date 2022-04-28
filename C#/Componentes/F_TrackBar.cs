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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_set.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_set.Text == "")
                {
                    MessageBox.Show("Valor não pode ser nulo!", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.Parse(tb_set.Text) < trackBar1.Minimum)
                    {
                        MessageBox.Show("Valor não pode ser menor do que " + trackBar1.Minimum.ToString() + "!", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(tb_set.Text) > trackBar1.Maximum)
                    {
                        MessageBox.Show("Valor não pode ser maior do que " + trackBar1.Maximum.ToString() + "!", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    trackBar1.Value = int.Parse(tb_set.Text);
                    label1.Text = tb_set.Text;
                }
            }
            catch
            {
                MessageBox.Show("Cadeia de caráteres inválida!", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {
            tb_set.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
