using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Academia : Aluno
    {
        public List<Aluno> Alunos { get; set; }

        public Aluno()
        {
            Alunos = new List<Aluno>();

        }
        public void AdicionaAluno(Alunos aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionaAluno(string nome, string cpf, string rg, string turma, double mensalidade)
        {
            Alunos.Add(new Aluno(nome, cpf, rg, turma, mensalidade));
        }

        public void DeletarAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

        public void SalvarAluno(Aluno aluno)
        {
            foreach (var aluno in Alunos)
            {
                if (aluno.Nome.Equals(aluno.Nome))
                {
                    aluno.Cpf = aluno.Cpf;
                    aluno.Rg = aluno.Rg;
                    aluno.Turma = aluno.Turma;
                    aluno.PgtoMensalidade = aluno.PgtoMensalidade;
                }
            }
        }

    }

   
}
