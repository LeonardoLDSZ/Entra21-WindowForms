using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioCrud
{
    /*Nossa empresa foi contratada para desenvolver um sistema para um
    colégio, a partir disso é requisitado que no sistema 
    • Haja um formulário para cadastrar vários alunos
    • Os Alunos devem ter seus nomes completos, data de nascimento, ano
    em que estão matriculados ( 1o ao 9o ano), Sexo do Aluno, Nome do
    Responsável, CPF do Responsável, Nome do Segundo Responsável,
    CPF do segundo Responsável.
    • Deve ser possível Criar um novo registro de Aluno. Ao criar o registro
    do aluno deve ser validado se há pelo menos um Responsável com
    nome completo e documento informado, se a data de aniversário do
    aluno está preenchida, se o nome completo do aluno foi informado e
    se o ano em que ele está matriculado foi preenchido. Caso uma
    dessas condições não seja satisfeita deve surgir uma mensagem
    alertando o usuário do campo que falta ser preenchido
     * 
    • Deve ser possível selecionar um dos alunos cadastrados previamente
    • Deve ser possível atualizar os dados referentes ao aluno selecionado
    • Deve ser possível excluir um aluno

    • Dicas:
    Para campos que só aceitam números utilizem o componente
    MaskedTextBox
    Para campos de data, utilize o DateTimePicker, e o tipo de dados
    DateTime para as variáveis que forem necessárias.
    Utilizem como exemplo o formulário desenvolvido na aula passada
     
     */
    public partial class Form1 : Form
    {
        List<string> nomes, cpfs, cpfsResponsaveis, sexos,
            responsaveis, matriculas;
        bool novo;

         public Form1()
        {
            InitializeComponent();
            nomes = new List<string>();
            sexos = new List<string>();
            responsaveis = new List<string>();
            cpfs = new List<string>();
            cpfsResponsaveis = new List<string>();
            matriculas = new List<string>();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            txtNome.Text = "";
            txtSexo.Text = "";
            maskedTextBoxCpfAluno.Text = "";
            txtMatricula.Text = "";
            txtPrimeiroResponsavel.Text = "";
            maskedTextBoxCpfPrimeiroResponsavel.Text = "";
            txtSegundoResponsavel.Text = "";
            maskedTextBoxCpfSegundoResponsavel.Text = "";
            txtNome.Focus();
            btnRegistrar.Enabled = true;

            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          
            if (novo)
            {
                nomes.Add(txtNome.Text);
                sexos.Add(txtSexo.Text);
                cpfs.Add(maskedTextBoxCpfAluno.Text);
                matriculas.Add(txtMatricula.Text);
                responsaveis.Add(txtPrimeiroResponsavel.Text);
                responsaveis.Add(txtSegundoResponsavel.Text);
                cpfsResponsaveis.Add(maskedTextBoxCpfPrimeiroResponsavel.Text);
                cpfsResponsaveis.Add(maskedTextBoxCpfSegundoResponsavel.Text);
            }
            else
            {
                nomes[listBox1.SelectedIndex] = txtNome.Text;
                sexos[listBox1.SelectedIndex] = txtSexo.Text;
                cpfs[listBox1.SelectedIndex] = maskedTextBoxCpfAluno.Text;
                matriculas[listBox1.SelectedIndex] = txtMatricula.Text;
                responsaveis[listBox1.SelectedIndex] = txtPrimeiroResponsavel.Text;
                responsaveis[listBox1.SelectedIndex] = txtSegundoResponsavel.Text;
                cpfsResponsaveis[listBox1.SelectedIndex] = maskedTextBoxCpfPrimeiroResponsavel.Text;
                cpfsResponsaveis[listBox1.SelectedIndex] = maskedTextBoxCpfSegundoResponsavel.Text;
            }
            listBox1.Items.Clear();
            foreach (var nome in nomes)
            {
                listBox1.Items.Add(nome);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
                nomes.RemoveAt(listBox1.SelectedIndex);
                sexos.RemoveAt(listBox1.SelectedIndex);
                matriculas.RemoveAt(listBox1.SelectedIndex);
                cpfs.RemoveAt(listBox1.SelectedIndex);
                responsaveis.RemoveAt(listBox1.SelectedIndex);
                cpfsResponsaveis.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txtNome.Text = nomes[listBox1.SelectedIndex];
                txtSexo.Text = sexos[listBox1.SelectedIndex];
                maskedTextBoxCpfAluno.Text = cpfs[listBox1.SelectedIndex];
                txtMatricula.Text = matriculas[listBox1.SelectedIndex];
                txtPrimeiroResponsavel.Text = responsaveis[listBox1.SelectedIndex];
                txtSegundoResponsavel.Text = responsaveis[listBox1.SelectedIndex];
                maskedTextBoxCpfPrimeiroResponsavel.Text = cpfsResponsaveis[listBox1.SelectedIndex];
                maskedTextBoxCpfSegundoResponsavel.Text = cpfsResponsaveis[listBox1.SelectedIndex];
                novo = false;
                btnRegistrar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
