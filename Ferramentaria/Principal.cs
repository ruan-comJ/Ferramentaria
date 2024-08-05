using System;
using System.Collections.Generic;
using Ferramentaria;


List<Funcionario> funcionarios = [];

int matricula; //Variável global

int opcao = 0;


//----------------------------------------------- M E N U  P R I N C I P A L ----------------------------------------------------//
while (opcao != 4)
{
    Console.WriteLine("MENU FERRAMENTARIA\n");
    Console.WriteLine
        (
        "1 - Buscar matricula no sistema\n" +
        "2 - Cadastrar novo funcionário\n" +
        "3 - Remover funcuinário do sistema\n" +
        "4 - Sair"
        );
    Console.Write("\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();


    switch (opcao)
    {
        case 1: // BUSCAR MATRICULA DO FUNCUINÁRIO
            Console.Clear();
            Console.Write("Insira a matricula do funcionário: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("\nBuscando matricula no banco de dados..\n");
            bool encontrado = false;
            foreach (Funcionario funcionarioBusca in funcionarios)
            {
                if (funcionarioBusca.Matricula == matricula) // MENU DO FUNCIONÁRIO SELECIONADO
                {
                    int opcaoFuncionario;

                    do
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Funcionário: " + funcionarioBusca.Nome);
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Função: " + funcionarioBusca.Funcao);
                        Console.WriteLine("--------------------------------------------");
                        encontrado = true;
                        Console.WriteLine("\nOpções: ");
                        Console.WriteLine("" +
                            "\n1 - Exibir itens do termo.\n"
                            + "2 - Adicionar item ao termo.\n"
                            + "3 - Remover item do termo\n"
                            + "4 - Voltar ao menu inicial");
                        Console.Write("\nEscolha um opção: ");
                        opcaoFuncionario = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcaoFuncionario)
                        {
                            case 1: // EXIBIÇÃO DOS ITENS PRESENTES NO TERMO DO FUNCIONÁRIO
                                Console.WriteLine("Itens no termo: \n");
                                foreach (string funcionarioItens in funcionarioBusca.Termo)
                                {
                                    Console.WriteLine(funcionarioItens + "\n");
                                }
                                break;

                            case 2: // ADICIONAR ITENS NO TERMO DO FUNCIONÁRIO
                                char maisItens = 's';
                                while (maisItens == 's' || maisItens == 'S')
                                {
                                    Console.Write("Insira o nome do item a ser adicionado ao termo do funcionário: ");
                                    string nomeItem = Console.ReadLine();
                                    funcionarioBusca.AdicionarItemNoTermo(nomeItem);

                                    // AJUSTAR DEPOIS !!!!!!!!!!!

                                    // Console.Write("\nInsira a quantidade do item \"" + funcionarios[i].Termo[indiceTermoAdd] + "\" que será adicionado ao termo: ");
                                    // funcionarios[i].Quantidade[indiceTermoAdd] = int.Parse(Console.ReadLine()); 



                                    Console.Clear();
                                    Console.WriteLine(nomeItem + " adicionado ao termo com sucesso!\n");
                                    Console.Write("Deseja adicionar mais itens ao termo (s/n) ? ");
                                    maisItens = char.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (maisItens == 'n' || maisItens == 'N')
                                    {
                                        Console.Clear();
                                    }
                                }
                                break;

                            case 3: // REMOVER ITENS DO TERMO DO FUNCIONÁRIO
                                int index = 0;
                                Console.WriteLine("Itens no termo: \n");
                                foreach (string item in funcionarioBusca.Termo)
                                {
                                    Console.WriteLine("Item " + index + " -> " + item + "\n");
                                    index++;
                                }

                                Console.Write("Escreva o nome do item para remove-lo do termo: ");
                                int remover = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n" + funcionarioBusca.Termo[remover] + " removido(a) do termo com sucesso!\n");
                                funcionarioBusca.RemoverDoTermo(remover);
                                break;

                            case 4:
                                break;


                            default:
                                Console.WriteLine("Opção inválida\n");
                                break;
                        }

                    } while (opcaoFuncionario != 4);
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Matricula não cadastrada no sistema.\n\n");
                Console.Write("Deseja cadastrar um novo funcionário (s/n) ? ");
                char cad = char.Parse(Console.ReadLine());
                if (cad == 's' || cad == 'S')
                {
                    Funcionario.CadastrarFuncionario(funcionarios);
                }
                else
                {
                    Console.Clear();
                }
            }
            break; // BUSCAR MATRICULA 


        case 2:
            Funcionario.CadastrarFuncionario(funcionarios);
            break; // CADASTRAR FUNCIONÁRIO


        case 3:
            Funcionario.RemoverFuncionario(funcionarios);
            break;

        case 4: // SAIR
            Console.Clear();
            Console.WriteLine("ENCERRANDO O PROGRAMA..");
            break;


    }

}
