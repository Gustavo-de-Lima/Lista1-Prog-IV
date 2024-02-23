using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv8_FaixaEtaria
{
    internal class FaixaEtaria
    {
        public void TestaFaixaEtaria() 
        {
            int anoNasc = 0;
            Console.WriteLine("Ola, seja bem vinde!!!");
            Console.WriteLine("Entre com o ano em que voce nasceu: ");
            anoNasc = Console.Read();

            string faixaEtaria = testaIdade(anoNasc);

            Console.WriteLine("Sua faixa etaria eh: " +  faixaEtaria);

        }

        public string testaIdade(int ano) 
        {
            string faixaEtaria = "";
            int anoAtual = 2024;

            int idade = anoAtual - ano;

            if (idade <= 19)
            {
                faixaEtaria = "Jovem";
            }
            else if (idade >= 20 && idade <= 59)
            {
                faixaEtaria = "Adulto";
            }
            else if (idade >= 60) 
            {
                faixaEtaria = "Idoso";
            }
            
            return faixaEtaria;
        }
    }
}
