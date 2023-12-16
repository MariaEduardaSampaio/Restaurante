using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    internal class Cozinheiro : Funcionario
    {
        public Cozinheiro(string nome, Jornada jornada, decimal salario) : base(nome, jornada, salario)
        {

        }
        public void PrepararPrato()
        {
            Console.WriteLine("Preparando prato...");
        }

        public void ChamarGarcom()
        {
            Console.WriteLine("Chamando garçom...");
        }

        public override decimal GetBonificacao()
        {
            return Salario * 0.15m;
        }
    }
}
