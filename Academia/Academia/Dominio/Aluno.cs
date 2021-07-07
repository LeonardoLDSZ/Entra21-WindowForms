using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Aluno : Pessoa
    {
        public string Turma { get; set; }
        public double Mensalidade { get; set; }

        public bool PgtoMensalidade { get; set; }


        public Aluno (string turma, double mensalidade)
        {
            Turma = turma;
            Mensalidade = mensalidade;
            if (PgtoMensalidade == true)
            {

            }
        }
      
       
        
    }
}
