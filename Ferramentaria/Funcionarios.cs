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

        public string[] Termo { get; set; }

        public int[] Quantidade { get; set; } 


        //--------------- CONSTRUTORES ---------------\\
        public Funcionarios(string nome, int matricula, string funcao)
        {
            Nome = nome;
            Matricula = matricula;
            Funcao = funcao;
            Termo = new string[10];
            Quantidade = new int[10];
        }
        

        //--------------- MÉTODOS ----------------\\

        
        public void CadastrarFuncionario(int index, string nome, int atricula, string funcao)
        {
            
        }
        
        public void AdicionarAoTermo(int index, string ferramenta)
        {
            Termo[index] = ferramenta;
        }

        public void RemoverDoTermo(int index) { } //
    }
}
