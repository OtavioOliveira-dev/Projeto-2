using AulaEncapsulamento;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",500.00,10);

            p.SetNome("Tv 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco().ToString("F2"));
            Console.WriteLine(p.GetQuantidade());
        }
    }
}