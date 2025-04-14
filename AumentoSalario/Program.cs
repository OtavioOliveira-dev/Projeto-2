// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Xml;

namespace AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario fun = new Salario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine( );

            Console.WriteLine("Funcionário: "+ fun );
            Console.WriteLine();

            Console.Write("Digite a porcentagem do aumento:");

            double pct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             fun.AlmentarSalario(pct);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: "+ fun);
        }
    }
}