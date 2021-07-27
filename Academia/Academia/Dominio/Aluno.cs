using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Aluno : Pessoa
    {
        public string Turma { get; set; }
        public bool PgtoMensalidade { get; set; }
        public Aluno(string nome, string cpf, string telefone, string turma, bool pgtoMensalidade)
        { 
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Turma = turma;
            PgtoMensalidade = pgtoMensalidade;
        }

        public override string ToString()
        {
            return Nome;
        }

        //public class Aluno : Pessoa
        //{
        //    public string Turno { get; set; }
        //    public Modalidade Modalidade { get; set; }
        //    public string Pagou { get; set; }

        //    public Aluno(string nome, string telefone, string cpf, string turno, Modalidade modalidade)
        //    {
        //        Nome = nome;
        //        Telefone = telefone;
        //        CPF = cpf;
        //        Turno = turno;
        //        Modalidade = modalidade;
        //        Pagou = "Não.";
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Nome} - {Turno} - {Modalidade} - Pagou: {Pagou}";
        //    }
        //}

    }
}
