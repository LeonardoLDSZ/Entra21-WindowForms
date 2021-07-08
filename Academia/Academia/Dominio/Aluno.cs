using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Aluno : Pessoa
    {
        public string Turma { get; set; }
        public bool PgtoMensalidade { get; set; }
        public Aluno(string nome, string cpf, string rg, string turma, bool pgtoMensalidade)
        { 
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Turma = turma;
            PgtoMensalidade = pgtoMensalidade;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
