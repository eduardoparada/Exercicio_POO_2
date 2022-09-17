using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_POO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e) //cliquei na label errado, desconsiderem programar!
        {

        }

        Dados_Jogador obj;
        Dados_Jogador[] v = new Dados_Jogador[5];
        int i = 0 , j=0;

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (i<5)
            {
                obj = new Dados_Jogador();

                obj.Nome = txtnome.Text;
                obj.Peso = Convert.ToDouble(txtpeso.Text);
                obj.Altura = Convert.ToDouble(txtaltura.Text);
                obj.Idade = Convert.ToInt32(txtidade.Text);
                obj.Camisa = Convert.ToInt32(txtcamisa.Text);
                obj.Time = txttime.Text;
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar mais jogadores!");
            }
            
        }
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            for (j = 0; j < 5; j++)
            {
                if (v[j].Nome.Equals(txtnome.Text))
                {
                    
                    txtpeso.Text = v[j].Peso.ToString();
                    txtaltura.Text = v[j].Altura.ToString();
                    txtidade.Text = v[j].Idade.ToString();
                    txtcamisa.Text = v[j].Camisa.ToString();
                    txttime.Text = v[j].Time;
                    j = 4;

                }
                else
                {
                    if (j == 4) MessageBox.Show("Time não encontrado!");
                }
            }
        }
    }
}
