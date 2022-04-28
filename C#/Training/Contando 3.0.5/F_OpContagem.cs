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
    public partial class F_OpContagem : Form
    {
        public F_OpContagem()
        {
            InitializeComponent();
        }

        private void contagemPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Config f_Config = new F_Config();
            f_Config.ShowDialog();
        }

        private void btn_contar_Click(object sender, EventArgs e)
        {
            F_Config config = new F_Config();
            F_Contagem f_Contagem = new F_Contagem(0, config, this);
            f_Contagem.ShowDialog();
        }
    }
}
