using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    internal class Garcom : Funcionario
    {
        public Garcom(string nome, Jornada jornada, decimal salario) : base(nome, jornada, salario)
        {
        }
    }
}
