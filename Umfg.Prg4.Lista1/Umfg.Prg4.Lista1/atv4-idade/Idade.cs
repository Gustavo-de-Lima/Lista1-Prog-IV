using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv4_idade
{
    internal class Idade
    {
        private static int ANO_ATUAL = 2024;
        public void calcIdade() 
        {
            int anoNasc, idade = 0;
            Console.WriteLine("Ola, seja bem vinde!!!");
            Console.WriteLine("Entre com o ano que voce nasceu: ");
            anoNasc = Console.Read();

            if (anoNasc.Equals(0))
            {
                throw new Exception("Entrada invalida!!!");
            }
            
            idade = ANO_ATUAL - anoNasc;

            Console.WriteLine("Sua idade eh: " +  idade);
           
        
        }
    }
}
