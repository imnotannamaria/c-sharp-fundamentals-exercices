using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // Para executar uma das funcionalidades, descomente a chamada correspondente
        // SendWelcomeMessage();
        // ConcatNameAndSurName();
        // Calc();
        // CountCharacters();
        // VerifyCarNumber();
        // DisplayCurrentDate();
    }

    public static void SendWelcomeMessage()
    {
        Console.WriteLine("Qual seu nome?");
        string name = Console.ReadLine();
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public static void ConcatNameAndSurName()
    {
        Console.WriteLine("Qual seu primeiro Nome?");
        string name = Console.ReadLine();

        Console.WriteLine("Qual seu segundo Nome?");
        string surname = Console.ReadLine();

        Console.WriteLine($"Olá, {name} {surname}! Seja muito bem-vindo!");
    }

    public static void Calc()
    {
        Console.WriteLine("Digite o primeiro número:");
        string num1Text = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        string num2Text = Console.ReadLine();

        if (double.TryParse(num1Text, out double num1) && double.TryParse(num2Text, out double num2))
        {
            double sum = num1 + num2;
            Console.WriteLine($"Soma desses dois valores: {sum}");

            double subs = num1 - num2;
            Console.WriteLine($"Subtração desses dois valores: {subs}");

            double mult = num1 * num2;
            Console.WriteLine($"Multiplicação desses dois valores: {mult}");

            double div = num1 / num2;
            Console.WriteLine($"Divisão desses dois valores: {div}");

            double avg = (num1 + num2) / 2;
            Console.WriteLine($"Média desses dois valores: {avg}");
        }
        else
        {
            Console.WriteLine("Por favor, insira números válidos.");
        }
    }

    public static void CountCharacters()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string input = Console.ReadLine();

        int characterCount = 0;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                characterCount++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres (excluindo espaços) é: {characterCount}");
    }

    public static void VerifyCarNumber()
    {
        Console.WriteLine("Digite a placa de um veículo:");
        string input = Console.ReadLine();

        string pattern = @"^[A-Za-z]{3}[0-9]{4}$";

        bool isValid = Regex.IsMatch(input, pattern);

        Console.WriteLine(isValid ? "Verdadeiro" : "Falso");
    }

    public static void DisplayCurrentDate()
    {
        Console.WriteLine("Escolha o formato para exibir a data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"dd/MM/yyyy\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");
        Console.Write("Digite a opção desejada (1-4): ");

        string option = Console.ReadLine();

        DateTime currentDate = DateTime.Now;

        switch (option)
        {
            case "1":
                // Formato completo
                Console.WriteLine("Data atual (formato completo):");
                Console.WriteLine(currentDate.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));
                break;

            case "2":
                // Apenas a data no formato "dd/MM/yyyy"
                Console.WriteLine("Data atual (apenas a data):");
                Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
                break;

            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine("Hora atual (formato de 24 horas):");
                Console.WriteLine(currentDate.ToString("HH:mm:ss"));
                break;

            case "4":
                // A data com o mês por extenso
                Console.WriteLine("Data atual (com mês por extenso):");
                Console.WriteLine(currentDate.ToString("dd 'de' MMMM 'de' yyyy"));
                break;

            default:
                Console.WriteLine("Opção inválida! Por favor, escolha um número entre 1 e 4.");
                break;
        }
    }
}
