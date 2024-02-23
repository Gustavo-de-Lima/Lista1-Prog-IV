using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv3_autonomia
{
    internal class Autonomia
    {
        static void Main()
        {
            double km, lts = 0.0d;

            Console.WriteLine("Ola, seja bem vinde!!!!");
            Console.WriteLine("Entre com os quilometros rodados: ");
            km = Console.Read();

            Console.WriteLine("Entre com a quantidade de litros gastos: ");
            lts = Console.Read();

            if (km.Equals(0.0) ||  lts.Equals(0.0))
            {
                throw new Exception("Valores invalidos!!!!");
            }

            double resultado = lts / km;

            Console.WriteLine("O resultado eh: " +  resultado);


        }
    }
}
