using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        private Dominio.Academia academia;
        public Form1()
        {
            InitializeComponent();
            academia = new Dominio.Academia();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            academia.CadastrarAluno(new Dominio.Aluno(txtAluno.Text, maskedTextCpf.Text, 
                maskedTextRg.Text, txtTurma.Text, checkBoxPago.Checked));
      
            //academia.CadastrarAluno(new Dominio.Aluno(checkBoxPago,false));


            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxAlunos.Items.Clear();
            foreach (var aluno in academia.Alunos)
            {
                listBoxAlunos.Items.Add(aluno);
                
            }
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
