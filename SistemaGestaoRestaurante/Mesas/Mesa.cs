using System;

namespace SistemaGestaoRestaurante.Mesas
{
    internal class Mesa
    {
      
        Dictionary<int, StatusMesa> Mesas = new Dictionary<int, StatusMesa>()
        {
            { 01, StatusMesa.Livre },
            { 02, StatusMesa.AguardandoPrato },
            { 03, StatusMesa.Livre },
            { 04, StatusMesa.Livre },
            { 05, StatusMesa.Livre },
            { 06, StatusMesa.Livre },
            { 07, StatusMesa.Livre },
            { 08, StatusMesa.Livre },
            { 09, StatusMesa.Livre },
            { 10, StatusMesa.Livre },
            { 11, StatusMesa.Livre },
            { 12, StatusMesa.Livre },
        };

        public void ReservarMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Reservada;
        }

        public void SolicitarAtendimento(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoAtendimento;
            Console.WriteLine($"Mesa {idMesa} chamou o garçom");
        }

        public void AguardarPedido(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoPrato;
        }

        public void MesaOcupada(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Ocupada;
        }

        public void LiberarMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Livre;
        }

        public void ExibirMesasAguardandoAtendimento()
        {
            Console.WriteLine("Mesas aguardando atendimento:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.AguardandoAtendimento)
                {
                    Console.WriteLine($"Mesa: {mesa.Key}");
                }
            }

            if(!Mesas.ContainsValue(StatusMesa.AguardandoAtendimento))
                Console.WriteLine("Sem mesas aguardando atendimento.");
        }

        public void ExibirMesasAguardandoPrato()
        {
            Console.WriteLine("Mesas aguardando pedido:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.AguardandoPrato)
                {
                    Console.WriteLine($"Mesa: {mesa.Key}");
                }
            }

            if (!Mesas.ContainsValue(StatusMesa.AguardandoPrato))
                Console.WriteLine("Fila livre.");
        }



    }
}
