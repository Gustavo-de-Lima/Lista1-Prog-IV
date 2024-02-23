using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv5_calculadora
{
    internal class Calculadora
    {
        public void calculo()
        {
            Console.WriteLine("Ola, seja bem vinde!!!");
            Console.WriteLine("1- Soma;");
            Console.WriteLine("2- Subtracao;");
            Console.WriteLine("3- Multiplicacao;");
            Console.WriteLine("4- Divisao;");
            Console.WriteLine("5- Resto da divisao;");
            Console.WriteLine("Entre com a opcao desejada: ");
            int opcao = Console.Read();
            try
            {
                switch (opcao)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    case 5:
                        Resto();
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opcao Invalida!!!");
            }
        }

        public void Soma() 
        {
            Console.WriteLine("--SOMA--");
            Console.WriteLine("Entre com o primeiro valor: ");
            var numUm = Console.Read();
            Console.WriteLine("Entre com o segundo valor: ");
            var numDois = Console.Read();

            var resultado = numUm + numDois;
            Console.WriteLine("Resultado: " +  resultado);
        }

        public void Subtracao() 
        {
            Console.WriteLine("--SUBTRACAO--");
            Console.WriteLine("Entre com o primeiro valor: ");
            var numUm = Console.Read();
            Console.WriteLine("Entre com o segundo valor: ");
            var numDois = Console.Read();

            var resultado = numUm - numDois;
            Console.WriteLine("Resultado: " + resultado);
        }

        public void Multiplicacao() 
        {
            Console.WriteLine("--MULTIPLICACAO--");
            Console.WriteLine("Entre com o primeiro valor: ");
            var numUm = Console.Read();
            Console.WriteLine("Entre com o segundo valor: ");
            var numDois = Console.Read();

            var resultado = numUm * numDois;
            Console.WriteLine("Resultado: " + resultado);
        } 

        public void Divisao() 
        {
            Console.WriteLine("--DiVISAO--");
            Console.WriteLine("Entre com o primeiro valor: ");
            var numUm = Console.Read();
            Console.WriteLine("Entre com o segundo valor: ");
            var numDois = Console.Read();

            var resultado = numUm / numDois;
            Console.WriteLine("Resultado: " + resultado);
        }

        public void Resto() 
        {
            Console.WriteLine("--RESTO DA DIVISAO--");
            Console.WriteLine("Entre com o primeiro valor: ");
            var numUm = Console.Read();
            Console.WriteLine("Entre com o segundo valor: ");
            var numDois = Console.Read();

            var resultado = numUm % numDois;
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
