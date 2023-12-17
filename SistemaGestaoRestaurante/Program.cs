using SistemaGestaoRestaurante.Funcionarios;
using SistemaGestaoRestaurante.Mesas;

namespace SistemaGestaoRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinheiro cozinheiro = new Cozinheiro("João", Jornada.Noite, 2500);

            Mesa mesa = new Mesa();

            mesa.ExibirMesasAguardandoAtendimento();
            mesa.ExibirMesasAguardandoPrato();

        }
    }
}