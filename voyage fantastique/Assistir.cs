using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voyage_fantastique
{
    public class Assistir
    {
        //vou usar 
        private string codigo;
        private string filme;
        private string diretor;
        private DateTime data;

        //propiedade 
        public string Codigo { get => codigo; private set => codigo = value; }
        public string Filme { get => filme; private set => filme = value; }
        public string Diretor { get => codigo; private set => diretor = value; }
        public DateTime Data { get => data; private set => data = value; }

        //metodo construtor 
        public Assistir(string codigo, string filme, string diretor, DateTime data)
        {
            this.codigo = codigo;
            this.filme = filme;
            this.diretor = diretor;
            this.data = data;
        }
    }
}
