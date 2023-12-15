﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    internal class Funcionario
    {
        public readonly string Id;
        public string Nome { get; set; }
        public Jornada Jornada { get; set; }
        public DateTime DataAdmissao { get; }
        public DateTime DataDemissao { get; private set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, Jornada jornada, decimal salario)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            Jornada = jornada;
            DataAdmissao = DateTime.Now;
            Salario = salario;
        }

        public void Demitir()
        {
            DataDemissao = DateTime.Now;
        }
    }
}