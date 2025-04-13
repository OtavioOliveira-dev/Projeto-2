using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("Calculadora");
            Console.WriteLine();
            Console.WriteLine("Entre com primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("[1] Somar");
            Console.WriteLine("[2] Subtrair");
            Console.WriteLine("[3] Multiplicar");
            Console.WriteLine("[4] Dividir");
            Console.WriteLine("[5] RestoDivisão");
            Console.WriteLine("[6] Potenciaçao");
            Console.WriteLine("[0] Sair");

            int opcao = int.Parse(Console.ReadLine());

            Menu menu = new Menu();
            menu.ExecutarOperacao(opcao, num1, num2);
        }
    }
}
