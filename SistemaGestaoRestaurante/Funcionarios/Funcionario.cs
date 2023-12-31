﻿using SistemaGestaoRestaurante.Mesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    public class Funcionario
    {
        public readonly Guid Id;
        public string Nome { get; private set; }
        public Jornada Jornada { get; private set; }
        public DateTime DataAdmissao { get; }
        public DateTime DataDemissao { get; private set; }
        public decimal Salario { get; private set; }
        public bool Ativo {  get; private set; }

        public Funcionario(string nome, Jornada jornada, decimal salario)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Jornada = jornada;
            DataAdmissao = DateTime.Now;
            Salario = salario;
            Ativo = true;
        }

        public void Demitir()
        {
            DataDemissao = DateTime.Now;
            Ativo = false;
        }
        public virtual decimal GetBonificacao()
        {
            return Salario * 0.10m;
        }
    }
}
