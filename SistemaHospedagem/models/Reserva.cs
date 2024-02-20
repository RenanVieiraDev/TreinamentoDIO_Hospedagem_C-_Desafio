using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes = new List<Pessoa>() ;
        private Suite suite { get; set; }
        private int dias { get; set; }

        public Reserva(List<Pessoa> hospedes, Suite suite, int dias) 
        {
            this.Hospedes = hospedes;
            this.suite = suite;
            this.dias = dias;
        }

        public string reservarAgora()
        {
            if (this.Hospedes.Count > this.suite.PegaCapacidade()) 
            {
                return $"Reserva não realizada, a capacidade da suite é de {this.suite.PegaCapacidade()} hospedes";
            }
            
            decimal valorTotalReserva = this.dias * this.suite.PegaValorDiaria();
            decimal valorDesconto = 0;
            
            if (this.dias >= 10)  valorDesconto = (valorTotalReserva * 10) / 100;

            return $"Reserva realizada com sucesso! O valor total ficou de R$ {valorTotalReserva - valorDesconto} da suite {this.suite.PegaTipo()} com total de {this.dias} dias.";

        }
    }
}
