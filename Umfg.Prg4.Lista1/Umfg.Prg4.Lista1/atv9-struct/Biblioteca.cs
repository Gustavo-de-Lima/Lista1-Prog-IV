namespace Umfg.Prg4.Lista1.atv9_struct
{
    internal class Biblioteca
    {
        class Program
        {
            static void Main()
            {
                LIvro.Livro livro;

                Console.WriteLine("Cadastro de Livro");
                Console.Write("Informe o Título do livro: ");
                livro.Titulo = Console.ReadLine();

                Console.Write("Informe o Autor do livro: ");
                livro.Autor = Console.ReadLine();

                Console.Write("Informe o Valor do livro: ");
                // Validando a entrada do valor
                while (!double.TryParse(Console.ReadLine(), out livro.Valor) || livro.Valor < 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, informe um valor válido.");
                    Console.Write("Informe o Valor do livro: ");
                }

                Console.WriteLine("\nDetalhes do Livro:\n" + livro.ToString());
            }
        }

    }
}
