using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_hospedagem_hotel.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes = new List<Pessoa>();
        private Suite Suite;
        private int DiasReservados;

        public Reserva() { }

        public Reserva(int diasReservados) {
            this.DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            if(Suite.GetCapacidade()<=Hospedes.Count) {
                Console.WriteLine("Esta reserva não comporta a quantidade de hospedes passadas.");
            } 
            else {
                foreach(Pessoa hospede in hospedes) {
                    Hospedes.Add(hospede);
                }
                Console.WriteLine("Hospedes adicionados na Reserva!");
            }
        }

        public void CadastrarSuite(Suite suite) {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes() {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria() {
            return 0;
        }
    }
}