using System;
using System.Globalization;

namespace CotacaoDollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do Dollar: ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade de dollar que deseja comprar: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Cotação.Convercao(cotacao, quantidade );

            Console.WriteLine($"Valor a ser pago em reais: {result.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}