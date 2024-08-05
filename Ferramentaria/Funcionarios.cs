using System;
using System.Collections.Generic;

namespace Ferramentaria

{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Matricula { get; private set; }
        public string Funcao { get; set; }

        public List<string> Termo { get; set; }

        public List<int> Quantidade { get; set; }


        //--------------- CONSTRUTORES ---------------\\
        public Funcionario(string nome, int matricula, string funcao)
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

        public void RemoverDoTermo(int remover)
        {
            Termo.RemoveAt(remover);
        }

        public static void CadastrarFuncionario(List<Funcionario> lista)
        {
            Console.Clear();
            Console.WriteLine("Faça o cadastro de um funcionário");
            Console.Write("\nInsira o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("\nInsira a matrícula do funcionário: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("\nInsira a função do funcionário: ");
            string funcao = Console.ReadLine();
            lista.Add(new Funcionario(nome, matricula, funcao));
            Console.WriteLine("\nFuncionário cadastrado com sucesso!\n");
            Console.WriteLine("---------------------------------------------\n");
        }

        public static void RemoverFuncionario(List<Funcionario> lista)
        {
            Console.Clear();
            Console.Write("Insira o número da matrícula do funcionário que será removido: ");
            int remover = int.Parse(Console.ReadLine());
            int i = 0;
            bool found = false;
            foreach (Funcionario funcionario in lista)
            {
                if (funcionario.Matricula == remover)
                {
                    found = true;
                    break;
                }
                else
                {
                    i++;
                }
            }
            if (found == true)
            {
                lista.RemoveAt(i);
                Console.WriteLine("\nFuncionário removido do sistema.\n");
            }
            else
            {
                Console.WriteLine("\nFuncionário não encontrado.\n");
            }
        }
    }
}
