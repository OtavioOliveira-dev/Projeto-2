using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calcular
    {
   
       
        public Calcular() { }
        public int Somar(int num1,int num2) 
        {
           
            return  num1 + num2;
            
        }
        public int Subtrair(int num1,int num2)
        { 
            return num1 - num2;
        }
        public int Multiplicar(int num1,int num2)
        {
            return num1 * num2;
             
        }
        public double Dividir(int num1,int num2) 
        {
          
            if (num2 == 0) 
            {
                Console.WriteLine("Divisão por zero não existe");
            }
           return (double) num1 / num2;

        }
        public double restoDivisao(int num1,int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divisão por zero não existe");
            }
            return (double) num1 % num2;
        }
        public double potencia(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }
    }

}
