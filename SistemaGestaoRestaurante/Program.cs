using SistemaGestaoRestaurante.Funcionarios;

namespace SistemaGestaoRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinheiro cozinheiro = new Cozinheiro("João", Jornada.Noite, 2500);
            Console.WriteLine("Hello, World!");
        }
    }
}