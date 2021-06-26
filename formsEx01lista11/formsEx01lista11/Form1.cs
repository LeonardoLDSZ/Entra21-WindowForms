using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsEx01lista11
{

    

    
    public partial class Form1 : Form
    {
        // 01-11
        /*
         * Faça um programa para calcular o estoque médio de uma peça, sendo que: 
            ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2. 
         */

        double qtdMin, qtdMax, qtdMedia;

        public Form1()
        {
            InitializeComponent();
        }

        private void estoqueMin_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt1.Text))
            {
                qtdMin = double.Parse(txt1.Text);
            }
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt2.Text))
            {
                qtdMax = double.Parse(txt2.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            qtdMedia = qtdMin + qtdMax / 2;
            MessageBox.Show($"{qtdMedia}");

            
        }
    }
}
