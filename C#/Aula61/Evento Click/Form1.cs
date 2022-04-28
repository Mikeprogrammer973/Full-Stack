using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula61
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

        private void l_txt_Click(object sender, EventArgs e)
        {

        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            //String txt;
            //txt = tb_txt.Text;
            l_txt.Text = tb_txt.Text;
        }
    }
}
