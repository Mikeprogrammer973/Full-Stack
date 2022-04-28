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
    public partial class F_BackgroundWorker : Form
    {
        int c = 0;
        int max = 7000;
        public F_BackgroundWorker()
        {
            InitializeComponent();
            progressBar1.Maximum = max;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < max; i++)
            {
                c++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(20);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Tarefa concluída!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "Tarefa concluída!";
            button1.Text = "Reiniciar";
            c = 0;
            progressBar1.Value = c;
            button1.Visible = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "Trabalhando...";
            progressBar1.Value = c;
            label2.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("BackgroundWorker está muito atarefado no momento, tente mais tarde!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            button1.Visible = false;
        }
    }
}
