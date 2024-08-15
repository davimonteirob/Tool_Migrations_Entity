﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_To_DataBaseCSharpe.Models
{
    public class Contas
    {
        public Contas(string nome, int numero, decimal saldo) 
        {
            Nome = nome;
            Numero = numero;
            Saldo = saldo;
        }

        [Key]
        public int IdConta { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
    }
}
