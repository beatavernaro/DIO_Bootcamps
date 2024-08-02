using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotelDIO.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }
        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                Console.WriteLine("A quantidade de hospedes é maior que a capacidade da suite");
                return;
            }
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal totalDiarias = Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                totalDiarias *= 0.9m;
            }
            return totalDiarias * DiasReservados;
        }
    }
}
