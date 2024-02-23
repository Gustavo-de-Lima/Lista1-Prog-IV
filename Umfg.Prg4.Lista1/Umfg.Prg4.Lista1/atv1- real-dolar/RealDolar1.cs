using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv1__real_dolar
{
    internal class RealDolar1
    {
        static double VALOR_COTACAO = 0.193259;
        public static void Main() 
        {
            Console.WriteLine("Ola, seja bem vinde!!!");
            Console.WriteLine("Entre com um valor em reais para ser convertido para dolares!!!!!: ");
            string reaisS = Console.ReadLine();

            Double reais = Double.Parse(reaisS);

            if (reais.Equals(0.0)) 
            {
                throw new Exception("Valores invalidos");
            }

            var convertido = reais * VALOR_COTACAO;

            Console.WriteLine("O valor convertido eh: " + convertido);
        }
    }
}
