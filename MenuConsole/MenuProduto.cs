using System;
using System.Collections.Generic;

namespace MenuConsole
{
    public class MenuProduto
    {
        
        public void Menu() { 
            List<Produto> produtos = new List<Produto>();



            bool menu = true;
            while (menu == true) {

                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("1- Adicionar Produto\n2- Deletar Produto\n3- Editar Produto\n4- Listar Produtos\n5- Voltar ao Menu Principal");
                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        AdicionarProdutos();
                        break;
                    case 2:
                        RemoverProdutos();
                        break;
                    case 3:
                        EditarProdutos();
                        break;
                    case 4:
                        ListarProdutos();
                        break;
                    case 5:
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Nenhuma das opções acima foi selecionada.");
                        break;
                }
            }

            void AdicionarProdutos() {
                Console.WriteLine("Módulo de adicionar produtos\nQuantos produtos você deseja inserir?");
                int add = int.Parse(Console.ReadLine());
                int codigo = 0;
                for (int cont = 1; cont <= add; cont++)
                {
                    bool vc = false;
                    while (vc == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Adicione o produto " + cont + " :");
                        Console.Write("Codigo: ");
                        codigo = int.Parse(Console.ReadLine());
                        bool verif = true;
                        if (verif == produtos.Exists(x => x.Codigo == codigo))
                        {
                            Console.WriteLine("O codigo informado já existe.");
                        }
                        else
                        {
                            vc = true;
                        }

                    }
                    Console.Write("Nome do Produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Quantidade: ");
                    int qtde = int.Parse(Console.ReadLine());
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine());

                    produtos.Add(new Produto() { Codigo = codigo, Nome = nome, Qtde = qtde, Preco = preco });

                }
                produtos.Sort();
            }

            void RemoverProdutos()
            {
                foreach (Produto obj in produtos)
                {
                    Console.WriteLine(obj);
                }

                bool rv = false;

                while (rv == false)
                {
                    Console.WriteLine("Insira o código de qual produto você deseja deletar: ");
                    int cdel = int.Parse(Console.ReadLine());

                    bool verif = false;

                    if (verif == produtos.Exists(x => x.Codigo == cdel)) {
                        Console.WriteLine("Codigo informado não existe. Digite Novamente: ");
                    }
                    else
                    {
                        produtos.RemoveAll(x => x.Codigo == cdel);
                        rv = true;
                    }
                }


            }

            void EditarProdutos()
            {
                foreach (Produto obj in produtos)
                {
                    Console.WriteLine(obj);
                }
                bool ev = false;
                while (ev == false)
                {
                    Console.WriteLine("Qual produto deseja editar? Insira o código: ");
                    int cedit = int.Parse(Console.ReadLine());

                    bool verif = false;

                    if (verif == produtos.Exists(x => x.Codigo == cedit))
                    {
                        Console.WriteLine("Codigo informado não existe. Digite Novamente: ");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Nome do Produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Quantidade: ");
                        int qtde = int.Parse(Console.ReadLine());
                        Console.Write("Preco: ");
                        double preco = double.Parse(Console.ReadLine());

                        produtos.RemoveAll(x => x.Codigo == cedit);
                        produtos.Add(new Produto() { Codigo = cedit, Nome = nome, Qtde = qtde, Preco = preco });

                        ev = true;
                    }
                }
            }

            void ListarProdutos()
            {
                try
                {
                    foreach (Produto obj in produtos)
                    {
                        Console.WriteLine(obj);
                    }
                }
                catch(DomainException e)
                {
                    Console.WriteLine("Sem estoque !");
                }
            }

            Console.WriteLine();
        }
    }
}