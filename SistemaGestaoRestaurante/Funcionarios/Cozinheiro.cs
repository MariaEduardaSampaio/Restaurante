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
        public static void PrepararPrato()
        {
            Console.WriteLine("Preparando prato...");
        }

        public static void ChamarGarcom()
        {
            Console.WriteLine("Chamando garçom...");
        }

        public static void AdicionarPratoCardapio(string nome, decimal preco)
        {
            Cardapio.AdicionarPrato(nome, preco);
            Console.WriteLine($"Prato {nome} adicionado ao cardápio!");
        }

        public static void RetirarPratoCardapio(int idPrato)
        {
            try {
                Cardapio.RemoverPrato(idPrato);
                Console.WriteLine("Prato retirado do cardápio!");
            } catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao retirar um prato do cardápio: {e}");
            }
        }

        public override decimal GetBonificacao()
        {
            return Salario * 0.20m;
        }
    }
}
