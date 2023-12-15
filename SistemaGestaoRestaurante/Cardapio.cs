using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Cardapio
    {
        List<Tuple<int, string, decimal>> cardapio = new List<Tuple<int, string, decimal>>
        {
            new Tuple<int, string, decimal>(1, "Arroz", 10.00m),
            new Tuple<int, string, decimal>(2, "Feijão", 5.00m),
            new Tuple<int, string, decimal>(3, "Porção de batata frita", 12.00m),
            new Tuple<int, string, decimal>(4, "Carne de sol", 20.00m),
            new Tuple<int, string, decimal>(5, "Salada", 15.00m),
            new Tuple<int, string, decimal>(6, "Torresminho", 15.00m),
            new Tuple<int, string, decimal>(7, "Macarrão", 15.00m),
            new Tuple<int, string, decimal>(8, "Mandioca frita", 12.00m),
            new Tuple<int, string, decimal>(9, "Caldo de feijão", 8.00m),
            new Tuple<int, string, decimal>(10, "Caldo de mandioca", 8.00m),
        };

        public void MostrarCardapio()
        {
            Console.WriteLine("Cardápio:");
            foreach (var item in cardapio)
            {
                Console.WriteLine($"{item.Item1} - {item.Item2} - R$ {item.Item3}");
            }
        }

        public void RemoverPrato(int id)
        {
            cardapio.RemoveAll(prato => prato.Item1 == id);
        }
        public void AdicionarPrato(int id, string nome, decimal preco)
        {
            cardapio.Add(new Tuple<int, string, decimal>(id, nome, preco));
        }
    }
}
