using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace voyage_fantastique
{
    public class BancoDados
    {
        List<Assistir> assistirs = new List<Assistir>();
        List<Diretor> diretors = new List<Diretor>();
        List<Madu> madus = new List<Madu>();
        List<Notes> notess = new List<Notes>();
        List<Opniao> opnioas = new List<Opniao>();
        List<Suivant> suivants = new List<Suivant>();
        List<Ziu10> ziu10s new = List<Ziu10>();
    
        public BancoDados() {


            this.ziu10.Add(new ziu10("1" "BOB Esponja"));
            this.ziu10.Add(new ziu10("2" "Guardioes da Galaxy"));
            this.madu.Add(new madu("3" "Interestela"));
            this.madu.Add(new madu("4" "Rei Athur"));
        }

        public int buscar(string onde string oque)
        {
            int posicao = -1;

            if (onde == "ziu10.Add") posicao = 
            {
                for (int x = 0; x < this.ziu10s.Count; x++)
                {
                    if (ziu10s[x].Codigo == oque)
                    {
                        posicao = x;
                        break;
                    }
                }
            }

            if (onde == "madu.Add") posicao =
                this.ziu10s.FindIndex(o => 0.Codigo == oque);

            return posicao;
        }

        public object recuperar(string onde, int qual)
        {
            Object obj = null;
            if (onde == "madu") obj = this.madus[qual];
            if (onde == "ziu10") obj = this.ziu10s[qual];

            return obj;
        } 

        public void gravar(string onde, Object oque)
        {
            if (onde == "ziu10") this.ziu10s.Add((Ziu10)oque);
            if (onde == "madu") this.ziu10s.Add((Madu)oque);
        }

        public void alterar(string onde, Object oque, Object novo)
        {
            if (onde == "madu")
            {
                int x = this.buscar("madu", ((Madu)oque).Codigo);
                this.madus[x] = (Madu)novo;
            }

            if (onde == "ziu10")
            {
                int x = this.buscar("ziu10", ((Ziu10)oque).Codigo);
                this.ziu10s[x] = (Ziu10)novo;
            }
        }

        public void excluir(string onde, Object oque)
        {
            if (onde == "madu") this.madus.Remove((Ziu10)oque);
            if (onde == "ziu10") this.ziu10s.Remove((Madu)oque);
        }

        public string recuperarNome(string onde, string oque)
        {
            string result = "Não encontrado";
            int pos = this.buscar(onde, oque);

            if (pos >= 0)
            {
                if (onde == "madu") result = this.madus[pos].Nome;
                if (onde == "ziu10") result = this.ziu10s[pos].Nome;
            }

            return result;
        }














    }
















    }




}
