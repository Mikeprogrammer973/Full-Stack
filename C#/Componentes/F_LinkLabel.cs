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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            lb_mul_links.Links.Add(0, 6, "www.google.com.br");
            lb_mul_links.Links.Add(9, 5, "www.youtube.com/webhacher");
            lb_mul_links.Links.Add(17, 7, "www.youtube.com");

            lb_mul_links.Links[1].Enabled = false;
        }

        private void lb_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://projects/Projetos/Projetos%20Front%20end/Mega%20Quiz/");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void lb_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            lb_calc.LinkVisited = true;
        }

        private void lb_mul_links_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
