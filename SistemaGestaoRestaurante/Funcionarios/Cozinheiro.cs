using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    internal class Cozinheiro : Funcionario
    {
        public Cozinheiro(string nome, Jornada jornada, decimal salario): base(nome, jornada, salario)
        {
            
        }
        public void PrepararPrato()
        {
            Console.WriteLine("Preparando prato...");
        }
    }
}
