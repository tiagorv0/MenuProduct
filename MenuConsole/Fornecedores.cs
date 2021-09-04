using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class Fornecedores
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }

        public Fornecedores()
        {

        }
            

        public Fornecedores(string razaoSocial, string nomeFantasia, string cNPJ)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJ = cNPJ;
        }

        public void CadastroFornecedor()
        {
            Console.WriteLine("---- CADASTRO DE FORNECEDOR ----");
            Console.WriteLine("Razao Social do Fornecedor:  ");
            string razaosocial = Console.ReadLine();
            Console.WriteLine("Nome Fantasia: ");
            string nfantasia = Console.ReadLine();
            Console.WriteLine("CNPJ: ");
            string cnpj = Console.ReadLine();

            List<Fornecedores> cfornecedor = new List<Fornecedores>();

            cfornecedor.Add(new Fornecedores(razaosocial, nfantasia, cnpj));
        }

        public override string ToString()
        {
            return "Razão Social: " + RazaoSocial + "\nNome Fantasia: " + NomeFantasia + "\nCNPJ: " + CNPJ;
        }
    }
}
