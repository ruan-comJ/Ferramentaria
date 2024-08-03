using System;
using System.Collections.Generic;
using Ferramentaria;


List<Funcionarios> funcionarios = [];

int matricula; //Variável global

int opcao = 0;


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
            foreach (Funcionarios funcionarioBusca in funcionarios)
            {
                if (funcionarioBusca.Matricula == matricula)
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
                    int opcaoFuncionario = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcaoFuncionario)
                    {
                        case 1:
                            Console.WriteLine("Itens no termo: \n\n");
                            foreach (string funcionarioItens in funcionarioBusca.Termo)
                            {
                                Console.WriteLine(funcionarioItens + "\n");
                            }
                            break;

                        case 2:
                            char maisItens = 's';
                            while (maisItens == 's')
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
                            }
                            break;

                        case 3:
                            int index = 0;
                            Console.WriteLine("Itens no termo: \n\n");
                            foreach (string item in funcionarioBusca.Termo)
                            {
                                Console.WriteLine("Item " + index + " -> " + item + "\n");
                                index++;
                            }

                            Console.Write("Escreva o nome do item para remove-lo do termo: ");
                            string Remover = (Console.ReadLine());
                            funcionarioBusca.RemoverDoTermo(Remover);
                            Console.WriteLine("\nItem removido do termo com sucesso!\n");
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
            break; // BUSCAR MATRICULA 


        case 2:
            Console.WriteLine("\nFaça o cadastro de um funcionário");
            Console.Write("\nInsira o nome do funcionário : ");
            string nome = Console.ReadLine();
            Console.Write("\nInsira a matrícula do funcionário: ");
            matricula = int.Parse(Console.ReadLine());
            Console.Write("\nInsira a função do funcionário: ");
            string funcao = Console.ReadLine();
            funcionarios.Add(new Funcionarios(nome, matricula, funcao));
            Console.WriteLine("\nFuncionário cadastrado com sucesso!\n");

            break; // CADASTRAR FUNCIONÁRIO

        case 3: // SAIR

            break;


    }

}
