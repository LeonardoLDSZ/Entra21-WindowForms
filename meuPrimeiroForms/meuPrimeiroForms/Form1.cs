using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuPrimeiroForms
{
    public partial class Form1 : Form
    {

        int numero1, numero2;
        const int tamanhoHistorico = 10;
        int[] historicoCalculadora = new int[tamanhoHistorico];
        int indiceHistorico = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //Adição//
            ExibicaoCalculo(numero1 + numero2);
            //historicoCalculadora[indiceHistorico] = numero1 + numero2;
            //indiceHistorico++;
            //MessageBox.Show($"{numero1 + numero2}");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //Subtração
            ExibicaoCalculo(numero1 - numero2);
            //historicoCalculadora[indiceHistorico] = numero1 - numero2;
            //indiceHistorico++;
            //MessageBox.Show($"{numero1 - numero2}");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            //Multiplicação

            ExibicaoCalculo(numero1 * numero2);

            //historicoCalculadora[indiceHistorico] = numero1 * numero2;
            //indiceHistorico++;
            //MessageBox.Show($"{numero1 * numero2}");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //Divisão
            if (numero2 == 0)
            {
                MessageBox.Show($"Impossível dividir por 0");
            }
            else
            {
                ExibicaoCalculo(numero1 / numero2);
            }
            //historicoCalculadora[indiceHistorico] = numero1 / numero2;
            //indiceHistorico++;
            //MessageBox.Show($"{numero1 / numero2}");
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            foreach (var item in historicoCalculadora)
            {
                if (item != 0)
                {
                    mensagem += $"{item} \n ";
                }
            }

            MessageBox.Show(mensagem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var exerc2 = new Exercicio2();
            exerc2.Show();
            //historicoCalculadora = new int[tamanhoHistorico];
            //indiceHistorico = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumero1.Text))
            {
                numero1 = int.Parse(txtNumero1.Text);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExibicaoCalculo(int valor)
        {
            if (indiceHistorico < historicoCalculadora.Length)
            {
                if (checkBox1.Checked)
                {
                    historicoCalculadora[indiceHistorico] = valor;
                    indiceHistorico++;
                    listBox1.Items.Add(valor);
                }
                MessageBox.Show($"{valor}");

                if (comboBox1.SelectedItem != null)
                {
                    MessageBox.Show(comboBox1.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show($"Memória cheia");
            }
        }
    }
}
