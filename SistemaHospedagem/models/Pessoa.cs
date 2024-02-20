using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set;}
        private int id { get; set; }

        public Pessoa(string nome,string sobrenome, int id)
        { 
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.id = id;
        }

        public string PegaNome() { return this.Nome; }
        public string PegaSobrenome() { return this.Sobrenome; }
        public string PegaNomecompleto() { return $"{this.Nome} {this.Sobrenome}"; }
        public int PegaId() { return this.id; }


    }
}
