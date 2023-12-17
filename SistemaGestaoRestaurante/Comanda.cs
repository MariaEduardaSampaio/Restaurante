using SistemaGestaoRestaurante.Mesas;
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
        public Mesa Mesa { get; set; }
        public List<int> Pedidos { get; set; }
        public decimal Valor { get; set; }
        public decimal TaxaDeServico { get; set; }

        public Comanda(string Cliente, int idMesa) 
        {
            IdComanda = Guid.NewGuid();
            this.Cliente = Cliente;
            this.IdMesa = idMesa;
            TaxaDeServico = 0.10m;
            Mesa.MesaOcupada(idMesa);
        }

        public void FecharComanda()
        {
            decimal soma = 0;
            foreach(int pedido in Pedidos)
            {
                soma += Cardapio.EncontrarPrecoDePrato(pedido);
            }
            Valor = soma;
            Mesa.LiberarMesa(IdMesa);
        }

        public void FazerPedido(int id)
        {
            if (Cardapio.ExistePrato(id))
                Pedidos.Add(id);
            else
                throw new Exception("Numero do prato inválido!");
        }
    }
}
