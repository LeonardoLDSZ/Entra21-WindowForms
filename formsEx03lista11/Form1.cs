using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsEx03lista11
{
    public partial class Form1 : Form
    {
        /*
         * 03 - Faça um programa para pagamento de comissão de vendedores de peças, levando-se em 
         * consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados: 
           - Identificação do vendedor 
           - Código da peça 
           - Preço unitário da peça 
           - Quantidade vendida
         */
        string vendedor, codigoPeca;
        int qtdVendida, precoUnitario, venda, comissao;
       

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            vendedor = Convert.ToString(txtVendedor);
        }

        private void txtPeca_TextChanged(object sender, EventArgs e)
        {
            codigoPeca = Convert.ToString(txtPeca);
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
           precoUnitario = Convert.ToInt32(txtPrecoUnitario.Text);
        }

        private void txtQtdVendida_TextChanged(object sender, EventArgs e)
        {
            qtdVendida = Convert.ToInt32(txtQtdVendida.Text);
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            int venda = qtdVendida * precoUnitario;
            comissao = (int)(venda + (venda * 0.05));
            txtComissao.Text = comissao.ToString();
        }

        private void txtComissao_TextChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show($"{txtVendedor.Text}, vendeu {txtQtdVendida.Text} unidades da peça de codigo {txtPeca.Text}, obtendo a comissão de R$ {txtComissao.Text}");
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
