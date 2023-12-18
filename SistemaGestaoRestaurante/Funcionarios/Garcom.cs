using SistemaGestaoRestaurante.Comandas;
using SistemaGestaoRestaurante.Mesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante.Funcionarios
{
    public class Garcom : Funcionario
    {
        public Garcom(string? nome, Jornada jornada, decimal salario) : base(nome, jornada, salario)
        {
        }

        public void ReservarMesa(int idMesa)
        {
            try
            {
                Mesa.ReservarMesa(idMesa);
                Console.WriteLine($"Mesa {idMesa} reservada!");
            } catch (Exception e)
            {
                Console.WriteLine($"Não foi possível reservar a mesa: {e}");
            }
        }

        public void LiberarMesa(int idMesa)
        {
            try
            {
                Mesa.LiberarMesa(idMesa);
                Console.WriteLine($"Mesa {idMesa} liberada!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Não é possível liberar a mesa: {e}");
            }
        }

        public void AtenderCliente(Comanda comanda, int idPedido)
        {
            try
            {
                comanda.FazerPedido(idPedido);
                Mesa.AguardarPedido(comanda.IdMesa);
                Console.WriteLine("Pedido feito!");
            } catch (Exception e)
            {
                Console.WriteLine($"Não foi possível atender o cliente: {e}");
            }
        }

        public void ServirCliente(Comanda comanda)
        {
            try
            {
                Mesa.ServirPedido(comanda.IdMesa);
                Console.WriteLine("Pedido servido!");
            } catch(Exception e)
            {
                Console.WriteLine($"Não foi possível servir o cliente: {e}");
            }
        }

        public void FecharComanda(Comanda comanda)
        {
            try
            {
                comanda.FecharComanda();
                Console.WriteLine($"Valor total da comanda é de R${comanda.Valor}");
            } catch(Exception e)
            {
                Console.WriteLine($"Não foi possível fechar a comanda: {e}");
            }
        }

        public override decimal GetBonificacao()
        {
            return Salario * 0.15m;
        }
    }
}
