using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voyage_fantastique
{
    public class Opniao
    {
        //vou usar 

        private string codigo;
        private string nome;
        private string diretor;
        private DateTime data;
        private string descricao;

        // propriedades
        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nome { get => nome; private set => nome = value; }
        


        // método construtor
        public Opniao(string cod, string nom, string nac)
        {
            this.codigo = cod;
          //
        }

    }
}
