using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DNascimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string cPF, DateTime dNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DNascimento = dNascimento;
        }

        public void CadastroCliente()
        {
            Console.WriteLine("---- CADASTRO DE CLIENTE ----");
            Console.WriteLine("Nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF do Cliente: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dnasc = DateTime.Parse(Console.ReadLine());

            List<Cliente> ccliente = new List<Cliente>();

            ccliente.Add(new Cliente(nome, cpf, dnasc));
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nCPF: " + CPF + "\n Data de Nascimento: " + DNascimento;
        }
    }
}
