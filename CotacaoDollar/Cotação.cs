using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDollar
{
    internal class Cotação
    {
        public static double IOF = 6.0;
        public static double Convercao(double quantidade, double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * IOF / 100.0;
        }
    }  
}
