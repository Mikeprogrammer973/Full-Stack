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
    public partial class F_Contagem : Form
    {
        
        public F_Contagem(int tipo, F_Config config, F_OpContagem f_Op)
        {
            InitializeComponent();

            //this.config = f_Config;

            try
            {
                if (tipo == 1)
                {//Contagem Personalizada
                    if (config.tb_init.Text == "" || config.tb_fim.Text == "" || config.tb_passo.Text == "")
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (int.Parse(config.tb_init.Text) < int.Parse(config.tb_fim.Text))
                        {//Contagem Progressiva
                            for (int c = int.Parse(config.tb_init.Text); c <= int.Parse(config.tb_fim.Text); c += int.Parse(config.tb_passo.Text))
                            {
                                tb_contagem.Text += c + " -> ";
                            }
                            tb_contagem.Text += "</>";
                        }
                        else if (int.Parse(config.tb_init.Text) > int.Parse(config.tb_fim.Text))
                        {//Contagem Regressiva
                            for (int c = int.Parse(config.tb_init.Text); c >= int.Parse(config.tb_fim.Text); c -= int.Parse(config.tb_passo.Text))
                            {
                                tb_contagem.Text += c + " -> ";
                            }
                            tb_contagem.Text += "</>";
                        }
                    }
                }

                        if (tipo == 0)
                        {//Opções de Contagens
                            if (f_Op.cbb_init.Text == "" || f_Op.cbb_fim.Text == "" || f_Op.cbb_passo.Text == "")
                            {
                                throw new Exception();
                            }
                            else
                            {
                                if (int.Parse(f_Op.cbb_init.Text) < int.Parse(f_Op.cbb_fim.Text))
                                {//Contagem Progressiva
                                    for (int c = int.Parse(f_Op.cbb_init.Text); c <= int.Parse(f_Op.cbb_fim.Text); c += int.Parse(f_Op.cbb_passo.Text))
                                    {
                                        tb_contagem.Text += c + " -> ";
                                    }
                                    tb_contagem.Text += "</>";
                                }
                                else if (int.Parse(f_Op.cbb_init.Text) > int.Parse(f_Op.cbb_fim.Text))
                                {//Contagem Regressiva
                                    for (int c = int.Parse(f_Op.cbb_init.Text); c >= int.Parse(f_Op.cbb_fim.Text); c -= int.Parse(f_Op.cbb_passo.Text))
                                    {
                                        tb_contagem.Text += c + " -> ";
                                    }
                                    tb_contagem.Text += "</>";
                                }
                            }
                        }              
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente!");
            }
        }

        private void contagemPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Config f_Config = new F_Config();
            f_Config.ShowDialog();
        }

        private void opçõesDeContagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_OpContagem f_OpContagem = new F_OpContagem();
            f_OpContagem.ShowDialog();
        }
    }
}
