using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Academia
    {
        public List<Aluno> Alunos { get; private set; }

        public Academia() 
        {
            Alunos = new List<Aluno>();
        } 


        public void CadastrarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            
            
        }
        public void AlterarAluno(Aluno aluno)
        {

        }
        public void DeletarAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

       
           
	

    }
       
}
