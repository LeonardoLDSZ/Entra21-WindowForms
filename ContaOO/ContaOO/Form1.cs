using ContaOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaOO
{
    public partial class Form1 : Form
    {
        Conta conta;
        List<Conta> contas = new List<Conta>();
        public Form1()
        {
            InitializeComponent();
            conta = new Conta(1, "Leonardo");

            //conta.Numero = 1;
            //conta.Titular = "Leonardo";
            conta.Deposita(20);
            contas.Add(conta);
            contas.Remove(conta);
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            if (conta.Saca(double.Parse(mskBoxSaldo.Text)))
            {
                MessageBox.Show($"Numero = {conta.Numero} " +
            $" Titular = {conta.Titular} Saldo Atual = {conta.Saldo}");
                conta.Saca(double.Parse(mskBoxSaldo.Text));
            }
            else
            {
                MessageBox.Show($"Saldo insuficiente. Saldo Atual = {conta.Saldo}");
            }
            mskBoxSaldo.Text = conta.Saldo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumeroConta.Text = conta.Numero.ToString();
            txtTitular.Text = conta.Titular;
            mskBoxSaldo.Text = conta.Saldo.ToString();
            
            
        }
    }
}
