using System;
using System.Collections.Generic;
using System.Linq;
using SistemaGestaoRestaurante;
using SistemaGestaoRestaurante.Comandas;
using SistemaGestaoRestaurante.Funcionarios;

namespace UsuarioInterface
{
    internal class Program
    {
        static void ListarOpcoes()
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Gerenciar Funcionários");
            Console.WriteLine("2. Gerenciar Cardápio");
            Console.WriteLine("3. Atuar como Garçom");
            Console.WriteLine("4. Atuar como Cozinheiro");
            Console.WriteLine("5. Sair");
        }
        static void Main(string[] args)
        {

            int opcaoMenuPrincipal;
            bool continuar;
            do
            {
                ListarOpcoes();
                opcaoMenuPrincipal = int.Parse(Console.ReadLine());
                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        GerenciarFuncionarios();
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
            } while (opcaoMenuPrincipal != 5);
        }

        private static void ListarFuncionarios(List<Funcionario> funcionarios)
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"Nome: {funcionario.Nome}" +
                    $"Jornada: {funcionario.Jornada}" +
                    $"Salário: {funcionario.Salario}\n");
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

        private static void GerenciarFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Escolha uma opção para gerenciar funcionários:");
            Console.WriteLine("1. Demitir Funcionário.");
            Console.WriteLine("2. Calcular Bônus do Funcionário");
            Console.WriteLine("3. Cadastrar novo Funcionário.");
            Console.WriteLine("4. Listar todos os funcionários.");
            Console.WriteLine("5. Voltar.");

            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Funcionario funcionarioEncontrado;
                    string nomeFuncionario;

                    ListarFuncionarios(funcionarios);
                    do
                    {
                        Console.WriteLine("Qual o nome do funcionário que deseja demitir?");
                        nomeFuncionario = Console.ReadLine();
                        funcionarioEncontrado = funcionarios.FirstOrDefault(funcionario => funcionario.Nome == nomeFuncionario);
                    } while (funcionarioEncontrado == null);
                    DemitirFuncionario(funcionarioEncontrado);
                    break;

                case 2:
                    ListarFuncionarios(funcionarios);
                    do
                    {
                        Console.WriteLine("Qual o nome do funcionário que deseja calcular a bonificação?");
                        nomeFuncionario = Console.ReadLine();
                        funcionarioEncontrado = funcionarios.FirstOrDefault(funcionario => funcionario.Nome == nomeFuncionario);
                    } while (funcionarioEncontrado == null);
                    CalcularBonusFuncionario(funcionarioEncontrado);
                    break;

                case 3:
                    Console.WriteLine("Entre com os dados do funcionário:");
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();

                    bool jornadaValida;
                    Jornada jornada;
                    do
                    {
                        Console.WriteLine("Jornada:");
                        jornadaValida = Enum.TryParse(Console.ReadLine(), out jornada);
                    } while (!jornadaValida);

                    Console.WriteLine("Salário:");
                    decimal salario = decimal.Parse(Console.ReadLine());
                    Funcionario funcionario = new Funcionario(nome, jornada, salario);
                    funcionarios.Add(funcionario);
                    Console.WriteLine("Funcionário criado com sucesso!");
                    break;

                case 4:
                    ListarFuncionarios(funcionarios);
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
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
                    Console.WriteLine("Entre com o nome do prato:");
                    string nomePrato = Console.ReadLine();
                    Console.WriteLine("Entre com o preço do prato:");
                    decimal precoPrato = decimal.Parse(Console.ReadLine());
                    Cardapio.AdicionarPrato(nomePrato, precoPrato);
                    break;

                case 3:
                    Console.WriteLine("Entre com o ID do prato:");
                    int idPrato = int.Parse(Console.ReadLine());
                    Cardapio.RemoverPrato(idPrato);
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
        public static void AtuarComoGarcom()
        {
            Garcom garcom = new Garcom("João", Jornada.Noite, 1800.00m);
            Console.WriteLine("Atuar como garçom:");
            Console.WriteLine("1. Criar uma comanda.");
            Console.WriteLine("2. Atender cliente.");
            Console.WriteLine("3. Servir cliente.");
            Console.WriteLine("4. Fechar comanda.");
            Console.WriteLine("5. Liberar mesa.");
            Console.WriteLine("6. Reservar mesa.");
            Console.WriteLine("7. Se demitir");
            Console.WriteLine("8. Retornar ao Menu Principal");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Entre com o nome do cliente:");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("Entre com o ID da mesa:");
                    int idMesa = int.Parse(Console.ReadLine());
                    Comanda comanda = new Comanda(nomeCliente, idMesa);
                    Console.WriteLine("Comanda criada com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Entre com o nome do cliente da comanda:");
                    nomeCliente = Console.ReadLine();
                    Console.WriteLine("Entre com o ID da mesa da comanda:");
                    idMesa = int.Parse(Console.ReadLine());
                    comanda = new Comanda(nomeCliente, idMesa);
                    Cardapio.MostrarCardapio();
                    Console.WriteLine("Entre com o número do prato:");
                    int idPedido = int.Parse(Console.ReadLine());
                    garcom.AtenderCliente(comanda, idPedido);
                    break;

                case 3:
                    Console.WriteLine("Entre com o nome do cliente da comanda:");
                    nomeCliente = Console.ReadLine();
                    Console.WriteLine("Entre com o ID da mesa da comanda:");
                    idMesa = int.Parse(Console.ReadLine());
                    comanda = new Comanda(nomeCliente, idMesa);
                    garcom.ServirCliente(comanda);
                    break;

                case 4:
                    Console.WriteLine("Entre com o nome do cliente da comanda:");
                    nomeCliente = Console.ReadLine();
                    Console.WriteLine("Entre com o ID da mesa da comanda:");
                    idMesa = int.Parse(Console.ReadLine());
                    comanda = new Comanda(nomeCliente, idMesa);
                    garcom.FecharComanda(comanda);
                    break;

                case 5:
                    Console.WriteLine("Entre com o ID da mesa da comanda:");
                    idMesa = int.Parse(Console.ReadLine());
                    garcom.LiberarMesa(idMesa);
                    break;

                case 6:
                    Console.WriteLine("Entre com o ID da mesa da comanda:");
                    idMesa = int.Parse(Console.ReadLine());
                    garcom.ReservarMesa(idMesa);
                    break;

                case 7:
                    garcom.Demitir();
                    break;

                case 8:
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }

        private static void AtuarComoCozinheiro()
        {
            Cozinheiro cozinheiro = new Cozinheiro("Zeca", Jornada.Noite, 2500.00m);
            Console.WriteLine("Atuar como cozinheiro:");
            Console.WriteLine("1. Chamar o garçom.");
            Console.WriteLine("2. Preparar prato.");
            Console.WriteLine("3. Retirar prato do cardápio.");
            Console.WriteLine("4. Adicionar prato do cardápio.");
            Console.WriteLine("5. Se demitir.");
            Console.WriteLine("6. Retornar ao Menu Principal");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cozinheiro.ChamarGarcom();
                    break;

                case 2:
                    cozinheiro.PrepararPrato();
                    break;

                case 3:
                    Cardapio.MostrarCardapio();
                    Console.WriteLine("Entre com o ID do prato:");
                    int idPrato = int.Parse(Console.ReadLine());
                    cozinheiro.RetirarPratoCardapio(idPrato);
                    break;

                case 4:
                    Cardapio.MostrarCardapio();
                    Console.WriteLine("Entre com o nome do prato:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Entre com o preço do prato:");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    cozinheiro.AdicionarPratoCardapio(nome, preco);
                    break;

                case 5:
                    cozinheiro.Demitir();
                    break;

                case 6:
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}