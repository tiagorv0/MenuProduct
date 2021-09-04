using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class Produto : IComparable
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Qtde { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, int qtde, double preco)
        {
            Nome = nome;
            Qtde = qtde;
            Preco = preco;
        }

        public Produto(int codigo, string nome, int qtde, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Qtde = qtde;
            Preco = preco;
        }

        public double SubTotal()
        {
            return Qtde * Preco;
        }


        public override string ToString()
        {
            return "Código: " + Codigo + ", Produto: " + Nome + ", Quantidade: " + Qtde + ", pelo preço de: R$" + Preco.ToString("F2")+". Sub-Total: R$"+SubTotal().ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Erro! Argumento não é um Produto");
            }

            Produto outro = obj as Produto;
            return Codigo.CompareTo(outro.Codigo);
        }
    }
}
