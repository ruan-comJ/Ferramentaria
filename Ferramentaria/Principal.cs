using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace Ferramentaria
{
    internal class Principal
    {
        static void Main(string[] args)
        {

            Funcionarios[] funcionarios = new Funcionarios[10];

            int matricula; //Variável global

            int opcao = 0;
            int index = 0;
            int indiceTermo;
            int indiceTermoAdd = 0;

            //----------------------------------------------- M E N U  P R I N C I P A L ----------------------------------------------------//
            while (opcao != 3)
            {
                Console.WriteLine("MENU FERRAMENTARIA\n");
                Console.WriteLine
                    (
                    "1 - Buscar matricula no sistema\n" +
                    "2 - Cadastrar novo funcionário\n" +
                    "3 - Sair"
                    );
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Insira a matricula do funcionário: ");
                        matricula = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nBuscando matricula no banco de dados..\n");
                        bool encontrado = false;
                        for (int i = 0; i < funcionarios.Length; i++)
                        {
                            if (funcionarios[i] != null && funcionarios[i].Matricula == matricula)
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Funcionário: " + funcionarios[i].Nome);
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Função: " + funcionarios[i].Funcao);
                                Console.WriteLine("--------------------------------------------");
                                encontrado = true;
                                indiceTermo = i;
                                Console.WriteLine("\nOpções: ");
                                Console.WriteLine("" +
                                    "\n1 - Mostrar termo.\n" 
                                    + "2 - Adicionar item ao termo.\n" 
                                    + "3 - Remover item do termo\n" 
                                    + "4 - Voltar ao menu inicial");
                                Console.Write("\nEscolha um opção: ");
                                int opcaoFuncionario = int.Parse(Console.ReadLine());
                                Console.Clear();

                                switch (opcaoFuncionario)
                                {
                                    case 1:
                                        for (indiceTermo = 0; indiceTermo < funcionarios[i].Termo.Length && funcionarios[i].Termo[indiceTermo] != null; indiceTermo++)
                                            Console.WriteLine(indiceTermo + " - " + funcionarios[i].Termo[indiceTermo] + "\n");
                                        break;

                                    case 2:
                                        char maisItens = 's';
                                        while (maisItens == 's')
                                        {
                                            Console.Write("Insira o nome do item a ser adicionado ao termo do funcionário: ");
                                            funcionarios[i].Termo[indiceTermoAdd] = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine(funcionarios[i].Termo[indiceTermoAdd] + " adicionado ao termo com sucesso!\n");
                                            indiceTermoAdd++;
                                            Console.Write("Deseja adicionar mais itens ao termo (s/n) ? ");
                                            maisItens = char.Parse(Console.ReadLine());
                                        }
                                        break;

                                    case 3:
                                        for (indiceTermo = 0; indiceTermo < funcionarios[i].Termo.Length && funcionarios[i].Termo[indiceTermo] != null; indiceTermo++)
                                            Console.WriteLine(indiceTermo + " - " + funcionarios[i].Termo[indiceTermo] + "\n");
                                        Console.Write("Escolha o número correspondente ao item para remove-lo do termo: ");
                                        int numRemover = int.Parse(Console.ReadLine());
                                        funcionarios[i].Termo[numRemover] = null;
                                        Console.WriteLine("Item removido do termo com sucesso!");
                                        break;

                                        case 4:
                                        break;
                                }

                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Matricula não cadastrada no sistema.\n");
                        }
                        break;


                    case 2:
                        Console.WriteLine("\nFaça o cadastro de um funcionário");
                        Console.Write("\nInsira o nome do funcionário : ");
                        string nome = Console.ReadLine();
                        Console.Write("\nInsira a matrícula do funcionário: ");
                        matricula = int.Parse(Console.ReadLine());
                        Console.Write("\nInsira a função do funcionário: ");
                        string funcao = Console.ReadLine();
                        funcionarios[index] = new Funcionarios(nome, matricula, funcao);
                        Console.WriteLine("\nFuncionário cadastrado com sucesso!\n");
                        index++;

                        break;

                    case 3:

                        break;


                }

            }





        }
    }
}
