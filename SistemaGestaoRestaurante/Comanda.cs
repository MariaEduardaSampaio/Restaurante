using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Comanda
    {
        public Guid IdComanda { get; private set; }
        public string Cliente { get; private set; }
        public int Mesa { get; set; }
        public List<int> Pedidos { get; set; }
        public decimal Valor { get; set; }
        public decimal TaxaDeServico { get; set; }
        public Cardapios Cardapio {  get; set; }

        public Comanda(string Cliente, int Mesa) 
        {
            IdComanda = Guid.NewGuid();
            this.Cliente = Cliente;
            this.Mesa = Mesa;
            TaxaDeServico = 0.10m;
        }

        public void FecharComanda()
        {
            decimal soma = 0;
            foreach(int pedido in Pedidos)
            {
                soma += Cardapio.EncontrarPrecoDePrato(pedido);
            }
            Valor = soma;
        }

        public void FazerPedidos(int id)
        {
            if (Cardapio.RetornaID(id))
            {
                Pedidos.Add(id);
            }
            else
            {
                throw new Exception("Numero do prato inválido!");
            }
        }
    }
}
