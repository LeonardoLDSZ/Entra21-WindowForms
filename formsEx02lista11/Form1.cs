using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsEx02lista11
{
    public partial class Form1 : Form
    {
        /*
         *  02 - Faça um programa que:  
            Leia a cotação do dólar 	
            Leia um valor em dólares 
            Converta esse valor para Real 
            Mostre o resultado 
         */
        double cotacao, valorDolar, valorReal=0.0;
        const int tamanhoHistorico = 5;
        int[] historicoConversao = new int[tamanhoHistorico];
        int indiceHistorico = 0;
        private void btnConverter_Click(object sender, EventArgs e)
        {
            valorReal = cotacao * valorDolar;
            MessageBox.Show($"O valor em real é de R$ {valorReal}");
        }
        private void checkBoxRegistrar_CheckedChanged(object sender, EventArgs e)
        {

            if (indiceHistorico < historicoConversao.Length)
            {
                if (checkBoxRegistrar.Checked)
                {
                    historicoConversao[indiceHistorico] = (int)valorReal;
                    indiceHistorico++;
                    listBox1.Items.Add(valorReal);
                }
            }
            else
            {
                MessageBox.Show($"Memória cheia");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            historicoConversao = new int[tamanhoHistorico];
            indiceHistorico = 0;
        }

        private void txtCotacao_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCotacao.Text))
            {
                cotacao = double.Parse(txtCotacao.Text);
            }
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDolar.Text))
            {
                valorDolar = double.Parse(txtDolar.Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
