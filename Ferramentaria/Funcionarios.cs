using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentaria

{
    internal class Funcionarios
    {
        public string Nome { get; set; }
        public int Matricula { get; private set; }
        public string Funcao { get; set; }

        public List<string> Termo { get; set; }

        public List<int> Quantidade { get; set; }


        //--------------- CONSTRUTORES ---------------\\
        public Funcionarios(string nome, int matricula, string funcao)
        {
            Nome = nome;
            Matricula = matricula;
            Funcao = funcao;
            Termo = [];
            Quantidade = [];

        }


        //--------------- MÉTODOS ----------------\\


        public void AdicionarItemNoTermo(string nomeItem)
        {
            Termo.Add(nomeItem);
        }



        public void RemoverDoTermo(string nomeItem)
        {
            Termo.Remove(nomeItem);
        }

     
    }
}
