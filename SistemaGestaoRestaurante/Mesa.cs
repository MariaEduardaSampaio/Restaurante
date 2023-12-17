using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoRestaurante
{
    internal class Mesa
    {
        public StatusMesa StatusMesa { get; set; }

        Dictionary<int, StatusMesa> Mesas = new Dictionary<int, StatusMesa>()
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

        public void ReservarMesa(int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Reservada;
        }

        public void SolicitarAtendimento (int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoAtendimento;
            Console.WriteLine($"Mesa {idMesa} chamou o garçom");
        }

        public void AguardarPedido (int idMesa)
        {
            Mesas[idMesa] = StatusMesa.AguardandoPrato;
        }

        public void MesaOcupada (int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Ocupada;
        }

        public void LiberarMesa (int idMesa)
        {
            Mesas[idMesa] = StatusMesa.Livre;
        }

        public void ExibirMesasAguardandoAtendimento()
        {

        }
   


    }
}
