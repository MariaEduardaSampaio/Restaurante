using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Pedido
    {
        public int IdPedido { get; set; }

        public Mesa Mesa { get; set; }
        public List<int> Pratos { get; set; }
        public int Clientes { get; set; }
        public decimal Gorjeta { get; set; }
        public Cardapios Cardapio {  get; set; }


        public Pedido() 
        {
            
        }
        public void FazerPedidos(int id)
        {
            if (Cardapio.RetornaID(id))
            {
                Pratos.Add(id);
            }
            else
            {
                throw new Exception("Numero do prato inválido!");
            }
        }
    }

   
}
