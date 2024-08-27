using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_hospedagem_hotel.Models
{
    public class Suite
    {
        private string TipoSuite;
        private int Capacidade;
        private decimal ValorDiaria;

        public int GetCapacidade() {
            return Capacidade;
        }
    }
}