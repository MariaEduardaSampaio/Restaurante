using SistemaGestaoRestaurante.Funcionarios;
using SistemaGestaoRestaurante.Mesas;

namespace SistemaGestaoRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinheiro cozinheiro = new("João", Jornada.Noite, 2500);

            Mesa.ExibirMesasAguardandoAtendimento();
            Mesa.ExibirMesasAguardandoPrato();
        }
    }
}