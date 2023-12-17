using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Cardapios
    {
        List<(int id, string nome, decimal preco)> cardapio = new List<(int id, string nome, decimal preco)>
        {
            (1, "Arroz", 10.00m),
            (2, "Feijão", 5.00m),
            (3, "Porção de batata frita", 12.00m),
            (4, "Carne de sol", 20.00m),
            (5, "Salada", 15.00m),
            (6, "Torresminho", 15.00m),
            (7, "Macarrão", 15.00m),
            (8, "Mandioca frita", 12.00m),
            (9, "Caldo de feijão", 8.00m),
            (10, "Caldo de mandioca", 8.00m),
        };

        public void MostrarCardapio()
        {
            Console.WriteLine("Cardápio:");
            foreach (var item in cardapio)
            {
                Console.WriteLine($"{item.id} - {item.nome} - R$ {item.preco}");
            }
        }

        public void RemoverPrato(int id)
        {
            cardapio.RemoveAll(prato => prato.id == id);
        }
        public void AdicionarPrato(int id, string nome, decimal preco)
        {
            cardapio.Add((id, nome, preco));
        }

        public bool RetornaID(int id)
        {

            foreach (var item in cardapio)
            {
                if (item.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public decimal EncontrarPrecoDePrato(int idPrato)
        {
            (int id, string nome, decimal preco) prato = cardapio.FirstOrDefault(prato => prato.id == idPrato);
            return prato.preco;
        }
    }
}
