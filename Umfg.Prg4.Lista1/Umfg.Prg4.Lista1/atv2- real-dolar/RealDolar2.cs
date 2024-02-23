using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv2__real_dolar;

    internal class RealDolar2
    {
    static double VALOR_COTACAO = 5.22;
    static void Main()
    {
        Console.WriteLine("Ola, seja bem vinde!!!");
        Console.WriteLine("Entre com um valor em reais para ser convertido para dolares: ");
        double reais = Console.Read();

        if (reais.Equals(0.0))
        {
            throw new Exception("Valor invalido!!!");
        }

        var convertido = reais * VALOR_COTACAO;

        Console.WriteLine("O valor convertido eh: " + convertido);
    }
}


