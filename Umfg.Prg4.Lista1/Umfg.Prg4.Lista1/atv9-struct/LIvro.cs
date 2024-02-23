using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Prg4.Lista1.atv9_struct
{
    internal class LIvro
    {
        public struct Livro
        {
            public string Titulo;
            public string Autor;
            public double Valor;

            public override string ToString()
            {
                return $"Título: {Titulo}\nAutor: {Autor}\nValor: R${Valor:F2}";
            }
        }
    }
}
