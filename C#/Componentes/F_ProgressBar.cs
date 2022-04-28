using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            progressBar1.Maximum = int.Parse(textBox2.Text);
            if (int.Parse(textBox1.Text) > progressBar1.Maximum || int.Parse(textBox1.Text) < progressBar1.Minimum)
            {
                MessageBox.Show("Valor iválido!");
                return;
            }
            progressBar1.Step = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if ((progressBar1.Maximum % progressBar1.Step) != 0)
            {
                MessageBox.Show("Valor inválido, escolhe uma valor que seja divisor de " + textBox2.Text);
                return;
            }
            for (int c = 0; c <= progressBar1.Maximum; c += progressBar1.Step)
            {
                label1.Text = c.ToString();
                progressBar1.Value = c;
                Thread.Sleep(200);
            }            
        }
    }
}
