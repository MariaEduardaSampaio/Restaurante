using SistemaGestaoRestaurante.Mesas;

namespace SistemaGestaoRestaurante.Comandas
{
    public class Comanda
    {
        public Guid IdComanda { get; private set; }
        public StatusComanda StatusComanda { get; private set; }
        public string Cliente { get; private set; }
        public int IdMesa { get; set; }
        public List<int> Pedidos { get; set; }
        public decimal Valor { get; set; }
        public decimal TaxaDeServico { get; set; }

        public Comanda(string Cliente, int idMesa)
        {
            IdComanda = Guid.NewGuid();
            StatusComanda = StatusComanda.Aberta;
            this.Cliente = Cliente;
            IdMesa = idMesa;
            Mesa.OcuparMesa(idMesa);
            Pedidos = new List<int>();
            TaxaDeServico = 0.10m;
        }

        public void FecharComanda()
        {
            decimal soma = 0;
            foreach (int idPedido in Pedidos)
            {
                soma += Cardapio.EncontrarPrecoDePrato(idPedido);
            }
            Valor = soma * (1 + TaxaDeServico);
            StatusComanda = StatusComanda.Fechada;
        }

        public void FazerPedido(int id)
        {
            if (Cardapio.ExistePrato(id))
                Pedidos.Add(id);
            else
                throw new Exception("Número do prato inválido!");
        }
    }
}
