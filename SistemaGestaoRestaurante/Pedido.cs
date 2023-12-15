using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Pedido
    {
        public int IdPedido { get; set; }

        public Mesa Mesa { get; set; }
        public int[] Pratos { get; set; }
        public int Clientes { get; set; }
        public decimal Gorjeta { get; set; }

        public Pedido() { }

    }
}
