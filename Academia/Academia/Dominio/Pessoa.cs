using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Pessoa
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        
        public Pessoa (string nome, string cpf, string rg)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
        }


    }
}
