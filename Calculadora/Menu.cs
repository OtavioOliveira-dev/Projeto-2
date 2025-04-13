using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu
    {
        public void ExecutarOperacao(int opcao,int num1,int num2)
        {
            Calcular calcular = new Calcular();
          
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Resultado: {calcular.Somar(num1,num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {calcular.Subtrair(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {calcular.Multiplicar(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Resultado: {calcular.Dividir(num1, num2)}");
                    break;
                case 5:
                    Console.WriteLine($"Resultado: {calcular.restoDivisao(num1, num2)}");
                    break;
                case 6:
                    Console.WriteLine($"Resultado: {calcular.potencia(num1,num2)}");
                    break;

                    default: Console.WriteLine($"Saindo");
                    break;

            }
        }
    }
}
