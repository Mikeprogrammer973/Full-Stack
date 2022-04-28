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
    public partial class F_Timer : Form
    {
        int num;
        int p;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            label1.Text = num.ToString();
            p = pictureBox1.Location.X;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Iniciar")
            {
                button1.Text = "Parar";
                timer1.Interval = 500;
                timer1.Start();
            }else if (button1.Text == "Parar")
            {
                button1.Text = "Continuar";
                timer1.Stop();
            }
            else if (button1.Text == "Continuar")
            {
                button1.Text = "Parar";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            label1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = 0;
            button1.Text = "Parar";
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*if(pictureBox1.Location.X == 549)
            {
                p = 2;
                pictureBox1.Location = new Point(p, 133);
            }
            p++;*/
            Random alt = new Random();
            int x = alt.Next(2, 549);
            int y = alt.Next(133, 267);
            pictureBox1.Location = new Point(x, y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "Mover Imagem")
            {
                button3.Text = "Parar Imagem";
                timer2.Start();
            }else if (button3.Text == "Parar Imagem")
            {
                button3.Text = "Mover Imagem";
                timer2.Stop();
            }
        }
    }
}
