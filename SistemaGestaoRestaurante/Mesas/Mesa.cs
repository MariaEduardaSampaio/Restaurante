using System;

namespace SistemaGestaoRestaurante.Mesas
{
    internal static class Mesa
    {
      
        public static Dictionary<int, StatusMesa> Mesas = new Dictionary<int, StatusMesa>()
        {
            { 01, StatusMesa.Livre },
            { 02, StatusMesa.Livre },
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

        public static void ReservarMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Reservada;
        }

        public static void SolicitarAtendimento(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoAtendimento;
            Console.WriteLine($"Mesa {idMesa} chamou o garçom");
        }

        public static void AguardarPedido(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoPrato;
        }

        public static void OcuparMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Ocupada;
        }

        public static void LiberarMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Livre;
        }

        public static void ExibirMesasAguardandoAtendimento()
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

        public static void ExibirMesasAguardandoPrato()
        {
            Console.WriteLine("Mesas aguardando pedido:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.AguardandoPrato)
                    Console.WriteLine($"Mesa: {mesa.Key}");
            }

            if (!Mesas.ContainsValue(StatusMesa.AguardandoPrato))
                Console.WriteLine("Fila livre.");
        }

        public static void ExibirMesasOcupadas()
        {
            Console.WriteLine("Mesas ocupadas:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.Ocupada)
                    Console.WriteLine($"Mesa: {mesa.Key}");
            }

            if (!Mesas.ContainsValue(StatusMesa.Ocupada))
                Console.WriteLine("Nenhuma mesa ocupada.");
        }

        public static void ExibirMesasLivres()
        {
            Console.WriteLine("Mesas livres:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.Livre)
                    Console.WriteLine($"Mesa: {mesa.Key}");
            }

            if (!Mesas.ContainsValue(StatusMesa.Livre))
                Console.WriteLine("Nenhuma mesa livre.");
        }

        public static void ExibirMesasReservadas()
        {
            Console.WriteLine("Mesas reservadas:");
            foreach (KeyValuePair<int, StatusMesa> mesa in Mesas)
            {
                if (mesa.Value == StatusMesa.Reservada)
                    Console.WriteLine($"Mesa: {mesa.Key}");
            }

            if (!Mesas.ContainsValue(StatusMesa.Reservada))
                Console.WriteLine("Fila livre.");
        }
    }
}
