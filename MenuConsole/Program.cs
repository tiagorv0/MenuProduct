using System;
using System.Collections.Generic;

namespace MenuConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu == true)
            {

                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("1- Cadastro Cliente\n2- Cadastro Funcionário\n3- Cadastro Fornecedor\n4- Cadastro Produtos\n5- Sair");
                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        Cliente c = new Cliente();
                        c.CadastroCliente();
                        break;
                    case 2:
                        Funcionario func = new Funcionario();
                        func.CadastroFuncionario();
                        break;
                    case 3:
                        Fornecedores forn = new Fornecedores();
                        forn.CadastroFornecedor();
                        break;
                    case 4:
                        MenuProduto mp = new MenuProduto();
                        mp.Menu();
                        break;
                    case 5:
                        Console.WriteLine("Bye-Bye");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Nenhuma das opções acima foi selecionada.");
                        break;
                }
            }
        }
    }
}
