﻿using SistemaGestaoRestaurante.Comandas;
using System;

namespace SistemaGestaoRestaurante.Mesas
{
    internal static class Mesa
    {
      
        public static Dictionary<int, (StatusMesa Status, List<Comanda> Comandas)> Mesas = new()
        {
            { 01, (StatusMesa.Livre, new List<Comanda>())},
            { 02, (StatusMesa.Livre, new List<Comanda>())},
            { 03, (StatusMesa.Livre, new List<Comanda>())},
            { 04, (StatusMesa.Livre, new List<Comanda>())},
            { 05, (StatusMesa.Livre, new List<Comanda>())},
            { 06, (StatusMesa.Livre, new List<Comanda>())},
            { 07, (StatusMesa.Livre, new List<Comanda>())},
            { 08, (StatusMesa.Livre, new List<Comanda>())},
            { 09, (StatusMesa.Livre, new List<Comanda>())},
            { 10, (StatusMesa.Livre, new List<Comanda>())},
            { 11, (StatusMesa.Livre, new List<Comanda>())},
            { 12, (StatusMesa.Livre, new List<Comanda>())},
        };

        public static void ReservarMesa(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");

            var mesaAtual = Mesas[idMesa];
            Mesas[idMesa] = (StatusMesa.Reservada, mesaAtual.Comandas);
        }

        public static void SolicitarAtendimento(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");

            Mesas[idMesa] = (StatusMesa.AguardandoAtendimento, Mesas[idMesa].Comandas);
            Console.WriteLine($"Mesa {idMesa} chamou o garçom");
        }

        public static void AguardarPedido(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");
            Mesas[idMesa] = (StatusMesa.AguardandoPrato, Mesas[idMesa].Comandas);
        }

        public static void ServirPedido(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");
            Mesas[idMesa] = (StatusMesa.Ocupada, Mesas[idMesa].Comandas);
        }

        public static void OcuparMesa(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");
            Mesas[idMesa] = (StatusMesa.Ocupada, Mesas[idMesa].Comandas);
        }

        public static void LiberarMesa(int idMesa)
        {
            if (idMesa > 12 || idMesa < 1)
                throw new ArgumentException("Não existe mesa com esta identificação.");

            List<Comanda> comandasMesa = Mesas[idMesa].Comandas;
            bool todasAsComandasFechadas = comandasMesa.All(comanda => comanda.StatusComanda == StatusComanda.Fechada);

            if (todasAsComandasFechadas)
                Mesas[idMesa] = (StatusMesa.Livre, comandasMesa);
            else
                throw new ArgumentException("Não é possível liberar a mesa se alguma comanda atrelada a ela estiver aberta.");
        }

        public static void ExibirMesasConformeStatus(StatusMesa statusMesa)
        {
            foreach (var mesa in Mesas)
            {
                if (mesa.Value.Status == statusMesa)
                    Console.WriteLine($"Mesa: {mesa.Key}");
            }
        } 
    }
}
