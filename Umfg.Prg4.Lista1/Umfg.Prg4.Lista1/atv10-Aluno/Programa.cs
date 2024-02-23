using System;
using System.Collections.Generic;

internal class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Cadastro de Notas");
            Console.WriteLine("3 - Cadastro Total de Faltas");
            Console.WriteLine("4 - Relação de Alunos, Notas, Média, Faltas e Situação");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Escolha uma opção: ");
            }

            switch (opcao)
            {
                case 1:
                    CadastroAluno();
                    break;
                case 2:
                    CadastroNotas();
                    break;
                case 3:
                    CadastroFaltas();
                    break;
                case 4:
                    ListarAlunos();
                    break;
            }

        } while (opcao != 0);
    }

    static void CadastroAluno()
    {
        Aluno aluno = new Aluno();
        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite o RA do aluno: ");
        while (!int.TryParse(Console.ReadLine(), out aluno.RA) || aluno.RA < 0)
        {
            Console.WriteLine("RA inválido. Digite um valor positivo.");
            Console.Write("Digite o RA do aluno: ");
        }

        alunos.Add(aluno);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void CadastroNotas()
    {
        Console.Write("Digite o RA do aluno para cadastrar as notas: ");
        int ra = int.Parse(Console.ReadLine());
        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno != null)
        {
            Console.Write("Digite a nota da prova (máximo 10): ");
            while (!double.TryParse(Console.ReadLine(), out aluno.NotaProva) || aluno.NotaProva < 0 || aluno.NotaProva > 10)
            {
                Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                Console.Write("Digite a nota da prova (máximo 10): ");
            }

            Console.Write("Digite a nota do trabalho (máximo 10): ");
            while (!double.TryParse(Console.ReadLine(), out aluno.NotaTrabalho) || aluno.NotaTrabalho < 0 || aluno.NotaTrabalho > 10)
            {
                Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                Console.Write("Digite a nota do trabalho (máximo 10): ");
            }

            Console.WriteLine("Notas cadastradas com sucesso!");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static void CadastroFaltas()
    {
        Console.Write("Digite o RA do aluno para cadastrar as faltas: ");
        int ra = int.Parse(Console.ReadLine());
        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno != null)
        {
            Console.Write("Digite o total de faltas do aluno: ");
            while (!int.TryParse(Console.ReadLine(), out aluno.TotalFaltas) || aluno.TotalFaltas < 0)
            {
                Console.WriteLine("Valor inválido. Digite um número inteiro positivo.");
                Console.Write("Digite o total de faltas do aluno: ");
            }

            Console.WriteLine("Faltas cadastradas com sucesso!");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static void ListarAlunos()
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno.ToString());
        }
    }
}

class Aluno
{
    public string Nome { get; set; }
    public int RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public int TotalFaltas { get; set; }

    public double CalcularMedia()
    {
        return (NotaProva * 7 + NotaTrabalho * 3) / 10;
    }

    public double CalcularFrequenciaPercentual()
    {
        return ((25 - TotalFaltas) / 25.0) * 100;
    }

    public string Situacao()
    {
        double media = CalcularMedia();
        double frequencia = CalcularFrequenciaPercentual();

        if (media >= 7 && frequencia >= 75)
            return "APROVADO";
        else
            return "REPROVADO";
    }

    public override string ToString()
    {
        return $"{Nome} (RA: {RA}) - Nota Prova: {NotaProva}, Nota Trabalho: {NotaTrabalho}, Média: {CalcularMedia():F2}, Faltas: {TotalFaltas}, Frequência: {CalcularFrequenciaPercentual():F2}%, Situação: {Situacao()}";
    }
}