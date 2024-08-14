using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voyage_fantastique
{
    public class Diretor
    {
        //dados
        private string codigo;
        private string nome;
        private string filme;

        //propriedades 

        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nome { get => nome; private set => nome = value; }
        public string Filme { get => filme; private set => filme = value; }


        //construtor 
        public Diretor(string codigo, string nome, string filme)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.filme = filme;
        }
    }
}
