using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotelDIO.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
