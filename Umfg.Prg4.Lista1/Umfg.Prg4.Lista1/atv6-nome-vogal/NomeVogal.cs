namespace Umfg.Prg4.Lista1.atv6_nome_vogal
{
    internal class NomeVogal
    {
        public void CalcVogal()
        {
            Console.WriteLine("Ola, seja bem vinde!!!!");
            Console.WriteLine("Entre com seu nome: ");
            String nome = Console.ReadLine();


            int quant = 0;
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i].Equals('A') || nome[i].Equals('E') ||
                    nome[i].Equals('I') || nome[i].Equals('O') || nome[i].Equals('U'))
                {
                    quant++;
                }
            }

            Console.WriteLine("A quantidade de vogais do seu nome eh: " + quant);
        }
    }
}
