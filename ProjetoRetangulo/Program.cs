// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System;

namespace ProjetoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.WriteLine("Entre com os valores: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}