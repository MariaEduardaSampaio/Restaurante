using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoRestaurante
{
    public static class Cardapio
    {
        private static int ultimoId = 10; 

        public static List<(int id, string nome, decimal preco)> cardapio = new()
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

        public static void MostrarCardapio()
        {
            Console.WriteLine("Cardápio:");
            foreach (var (id, nome, preco) in cardapio)
            {
                Console.WriteLine($"{id} - {nome} - R$ {preco}");
            }
        }

        public static void RemoverPrato(int id)
        {
            int pratosRetirados = cardapio.RemoveAll(prato => prato.id == id);
            if (pratosRetirados == 0)
                throw new ArgumentException("Não existe prato com este número de identificação!");
        }

        public static void AdicionarPrato(string nome, decimal preco)
        {
            ultimoId++;
            cardapio.Add((ultimoId, nome, preco));
        }

        public static bool ExistePrato(int id)
        {
            return cardapio.Exists(prato => prato.id == id); 
        }

        public static decimal EncontrarPrecoDePrato(int idPrato)
        {
            (int id, string nome, decimal preco) = cardapio.FirstOrDefault(prato => prato.id == idPrato);

            if (preco == 0.0m) // valor padrão de decimal caso cardapio não tenha um prato com o id passado
                throw new ArgumentException("Não existe prato com esta identificação.");

            return preco;
        }
    }
}
