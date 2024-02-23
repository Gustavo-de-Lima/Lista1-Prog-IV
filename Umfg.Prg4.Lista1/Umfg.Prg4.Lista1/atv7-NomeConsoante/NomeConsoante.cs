namespace Umfg.Prg4.Lista1.atv7_NomeConsoante
{
    internal class NomeConsoante
    {
        public void CalcNome()
        {
            Console.WriteLine("Ola, seja bem vinde!!!!");
            Console.WriteLine("Entre com seu nome: ");
            String nome = Console.ReadLine();


            int quant = 0;
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] != 'A' || nome[i] != 'E' ||
                    nome[i] != 'I' || nome[i] != 'O' || nome[i] != 'U')
                {
                    quant++;
                }
            }

            Console.WriteLine("A quantidade de consoantes do seu nome eh: " + quant);
        }
    }
}
