using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsEx04lista11
{
    public partial class Form1 : Form
    {

        /* 4 - Ler quatro valores numéricos inteiros e apresentar o resultado dois a 
         * dois da adição e multiplicação entre os valores lidos, baseando-se na utilização 
         * do conceito de propriedade distributiva. Dica: se forem lidas as variáveis A, B, C 
         * e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; 
         * depois B com C, B com D e por último C com D. Note que para cada operação serão 
         * utilizadas seis combinações. Assim sendo, devem ser realizadas doze operações de 
         * processamento, sendo seis para as adições e seis para as multiplicações. 
         */

        int A, B, C, D;
        int somaAB, somaAC, somaAD, somaBC, somaBD, somaCD;
        int multiAB, multiAC, multiAD, multiBC, multiBD, multiCD;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            A = int.Parse(txtA.Text);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            B = int.Parse(txtB.Text);
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            C = int.Parse(txtC.Text);
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            D = int.Parse(txtD.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            somaAB = A + B;
            somaAC = A + C;
            somaAD = A + D;
            somaBC = B + C;
            somaBD = B + D;
            somaCD = C + D;
            multiAB = A * B;
            multiAC = A * C;
            multiAD = A * D;
            multiBC = B * C;
            multiBD = B * D;
            multiCD = C * D;
            txtAB.Text = somaAB.ToString();
            txtAC.Text = somaAC.ToString();
            txtAD.Text = somaAD.ToString();
            txtBC.Text = somaBC.ToString();
            txtBD.Text = somaBD.ToString();
            txtCD.Text = somaCD.ToString();
            txtAxB.Text = multiAB.ToString();
            txtAxC.Text = multiAC.ToString();
            txtAxD.Text = multiAD.ToString();
            txtBxC.Text = multiBC.ToString();
            txtBxD.Text = multiBD.ToString();
            txtCxD.Text = multiCD.ToString();
        }

        private void txtAB_TextChanged(object sender, EventArgs e)
        {
            // somaAB = int.Parse(txtAB.Text);
            //txtAB.Text = somaAB.ToString();
        }
        private void txtAC_TextChanged(object sender, EventArgs e)
        {
            //somaAC = int.Parse(txtAC.Text);
            //txtAC.Text = somaAC.ToString();
        }
        private void txtAD_TextChanged(object sender, EventArgs e)
        {
            // somaAD = int.Parse(txtAD.Text);
            //txtAD.Text = somaAD.ToString();
        }
        private void txtBC_TextChanged(object sender, EventArgs e)
        {
            // somaBC = int.Parse(txtBC.Text);
           // txtBC.Text = somaBC.ToString();
        }
        private void txtBD_TextChanged(object sender, EventArgs e)
        {
            // somaBD = int.Parse(txtBD.Text);
           // txtBD.Text = somaBD.ToString();
        }

        private void txtCD_TextChanged(object sender, EventArgs e)
        {
           // somaCD = int.Parse(txtCD.Text);
            //txtCxD.Text = multiCD.ToString();
        }

        private void txtAxB_TextChanged(object sender, EventArgs e)
        {
            //multiAB = int.Parse(txtAxB.Text);
          //  txtAxB.Text = multiAB.ToString();
        }

        private void txtAxC_TextChanged(object sender, EventArgs e)
        {
            //multiAC = int.Parse(txtAxC.Text);
           // txtAxC.Text = multiAC.ToString();
        }

        private void txtAxD_TextChanged(object sender, EventArgs e)
        {
           // multiAD = int.Parse(txtAxD.Text);
           // txtAxD.Text = multiAD.ToString();
        }

        private void txtBxC_TextChanged(object sender, EventArgs e)
        {
           // multiBC = int.Parse(txtBxC.Text);
          //  txtBxC.Text = multiBC.ToString();
        }

        private void txtBxD_TextChanged(object sender, EventArgs e)
        {
            //multiBD = int.Parse(txtBxD.Text);
            //txtBxD.Text = multiBD.ToString();
        }

        private void txtCxD_TextChanged(object sender, EventArgs e)
        {
           // txtCxD.Text = multiCD.ToString();

            
        }

       

        

       

        

        

        
        
    }
}
