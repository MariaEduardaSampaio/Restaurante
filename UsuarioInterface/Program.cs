using SistemaGestaoRestaurante;
using SistemaGestaoRestaurante.Funcionarios;

namespace UsuarioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario garcom1 = new Garcom("José", Jornada.Tarde, 1600.00m);

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Gerenciar Funcionários");
            Console.WriteLine("2. Gerenciar Cardápio");
            Console.WriteLine("3. Atuar como Garçom");
            Console.WriteLine("4. Atuar como Cozinheiro");
            Console.WriteLine("5. Sair");

            int opcaoMenuPrincipal = int.Parse(Console.ReadLine());

            switch (opcaoMenuPrincipal)
            {
                case 1:
                    GerenciarFuncionarios(garcom1);
                    break;
                case 2:
                    GerenciarCardapio();
                    break;
                case 3:
                    AtuarComoGarcom();
                    break;
                case 4:
                    AtuarComoCozinheiro();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }

        private static void GerenciarFuncionarios(Funcionario funcionario)
        {
            Console.WriteLine("Escolha uma opção para gerenciar funcionários:");
            Console.WriteLine("1. Demitir Funcionário");
            Console.WriteLine("2. Calcular Bônus do Funcionário");
            Console.WriteLine("3. Voltar");

            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    DemitirFuncionario(funcionario);
                    break;
                case 2:
                    CalcularBonusFuncionario(funcionario);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }

        private static void DemitirFuncionario(Funcionario funcionario)
        {
            if (funcionario.Ativo)
            {
                funcionario.Demitir();
                Console.WriteLine($"O funcionário {funcionario.Nome} foi demitido com sucesso.");
            }
            else
            {
                Console.WriteLine($"O funcionário {funcionario.Nome} já está demitido.");
            }
        }

        private static void CalcularBonusFuncionario(Funcionario funcionario)
        {
            decimal bonus = funcionario.GetBonificacao();
            Console.WriteLine($"O bônus do funcionário {funcionario.Nome} é de {bonus}.");
        }

        private static void GerenciarCardapio()
        {

            Console.WriteLine("Escolha uma opção para gerenciar o cardápio:");
            Console.WriteLine("1. Mostrar Cardápio");
            Console.WriteLine("2. Adicionar Prato");
            Console.WriteLine("3. Remover Prato");
            Console.WriteLine("4. Retornar ao Menu Principal");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cardapio.MostrarCardapio();
                    break;
                case 2:
                    // cardapio.AdicionarPrato(); //tem que por os parâmetros
                    break;
                case 3:
                    // cardapio.RemoverPrato();
                    break;
                case 4:
                    // Voltar para o menu principal ou fazer qualquer outra coisa
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
        public static void AtuarComoGarcom()
        {
            //criar commanda
            //entregar prato...
        }

        private static void AtuarComoCozinheiro()
        {

        }
    }
}