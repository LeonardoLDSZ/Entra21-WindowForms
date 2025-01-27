﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Dominio
{
    public class Categoria
    {
        [Key]  //chave primaria da tabela
        public int Id { get; set; }
        [MaxLength(100)] //número máximo de caracter
        public string Nome { get; set; }
    }
}
