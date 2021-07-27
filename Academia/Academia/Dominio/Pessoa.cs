using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Dominio
{
    class Pessoa
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        
        public Pessoa (string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public Pessoa() { }


    }

    //namespace Classes.Dominio
    //{
    //    public abstract class Pessoa
    //    {
    //        public string Nome { get; set; }
    //        public string Telefone { get; set; }
    //        public string CPF { get; set; }
    //    }
    //}
}
