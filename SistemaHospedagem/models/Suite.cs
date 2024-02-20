using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.models
{
    public class Suite
    {
        private int id { get; set; }
        private string TipoSuite { get; set; }
        private int Capacidade { get; set; }
        private decimal ValorDiaria { get; set; }

        public Suite(int id,string tipoSuite,int capacidade,decimal valorDiaria) 
        {
            this.id = id;
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
        }


        public string PegaTipo() => this.TipoSuite;
        public int PegaCapacidade() => this.Capacidade;
        public decimal PegaValorDiaria() => this.ValorDiaria;
        public int PegaId() => this.id;

    }
}
