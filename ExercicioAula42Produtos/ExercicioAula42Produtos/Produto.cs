using System.Globalization;

namespace ExercicioAula42Produtos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome 
                   + ", $ " 
                   + Preco.ToString("F2",CultureInfo.InvariantCulture)
                   + ", " 
                   + Quantidade 
                   + " unidades, Total: $ " 
                   + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int q)
        {
            Quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            Quantidade -= q;
        }
    }
}
