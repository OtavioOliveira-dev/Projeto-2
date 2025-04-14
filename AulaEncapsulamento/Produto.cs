using System;
using System.Globalization;


namespace AulaEncapsulamento
{
    internal class Produto
    {
 // a troca do public pelo private é para fazer o encapsulamento
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }
//Contrutor de 3 argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
// chamada Get para apresentar o nome que está privado dentro do encapsulamento
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade() 
        {
            return _quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }
// chamada set para poder alterar o nome que está protegido dentro do encapsulamento 
        public void SetNome(string nome)
        {
// lógica adicionada para definier que a alteração só pode ser feita se nome não receber valor nulo e tiver mais de 1 caracter
            if (nome != null && nome.Length > 1)
            {

                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque() 
        { 
            return _preco * _quantidade;
        }    

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;  
        }
        public override string ToString()
        { 
            return _nome 
                + ", $"
                + _preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, total : $ "
                +ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);

        }

    }
}
