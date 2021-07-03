using System;
using System.Collections.Generic;
using System.Text;

namespace ContaOO.Dominio
{
    class Conta
    {
        public int Numero { get;  set; }
        public string Titular { get;  set; }
        public double Saldo { get; private set; } // get - pegar o valor da propriedade - set altera
        //public double saldo = 100.0;

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 100;
        }
       

        public bool Saca(double quantidade) //parametros letra minúsculas
        {
            if (Saldo >= quantidade)
            {
                Saldo -= quantidade;
                return true;                 // return = faz acabar a execução do método
            }
            return false;
        }
        public void Deposita(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}
