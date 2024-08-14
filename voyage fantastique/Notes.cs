using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voyage_fantastique
{
    public  class Notes
    {
        //vou usar 
        private string codigo;
        private string nome;
        private string diretor;
        private float nota;

        //quero salvar a nota

        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nome { get => nome; private set => nome = value; }
        public string Diretor { get => diretor; private set => diretor = value; }
        public float Nota { get => nota; private set => nota = value; }

        //construtor
        public Notes(string codigo, string nome, string diretor, float nota)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.diretor = diretor;
            this.nota = nota;
        }


    }
}
