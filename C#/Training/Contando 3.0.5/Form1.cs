using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contando_3._0._5
{
    public partial class F_Config : Form
    {
        public F_Config()
        {
            InitializeComponent();
        }

        private void opçõesDeContagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_OpContagem f_OpContagem = new F_OpContagem();
            f_OpContagem.ShowDialog();
        }

        private void btn_contar_Click(object sender, EventArgs e)
        {
            F_OpContagem f_OpContagem = new F_OpContagem();
            F_Contagem f_Contagem = new F_Contagem(1, this, f_OpContagem);
            f_Contagem.ShowDialog();
        }
    }
}
