using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class Funcionario
    {
        public string Nome { get; set; }
        public DateTime DNascimento { get; set; }
        public string CPF { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string cPF,DateTime dNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DNascimento = dNascimento;
        }

        public void CadastroFuncionario()
        {
            Console.WriteLine("---- CADASTRO DE FUNCIONÁRIO ----");
            Console.WriteLine("Nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dnasc = DateTime.Parse(Console.ReadLine());

            List<Funcionario> cfuncionario = new List<Funcionario>();

            cfuncionario.Add(new Funcionario(nome, cpf, dnasc));
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + "\nCPF: " + CPF + "\n Data de Nascimento: " + DNascimento;
        }
    }
}
