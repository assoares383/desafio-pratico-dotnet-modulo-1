using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        /*
         * 1. Crie um programa em que o usuário precisa digitar
         * um nome e uma mensagem de boas vindas personalizada
         * com o nome dele é exibida: Olá, Nome! Seja muito bem-vindo!  
         */ 
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        
        /*
         * 2. Crie um programa que concatene um nome e
         * um sobrenome inseridos pelo usuário e
         * ao final exiba o nome completo.
         */
        Console.Write("Digite seu nome: ");
        string nome1 = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome1 = Console.ReadLine();

        Console.WriteLine($"Nome completo: {nome1} {sobrenome1}");
        
        /*
         * 3. Crie um programa com 2 valores do tipo
         * double já declarados que retorne:
         * 
         *  - A soma entre esses dois números;
         *  - A subtração entre os dois números;
         *  - A multiplicação entre os dois números;
         *  - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
         *  - A média entre os dois números.
         */
        
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");

        if (num2 != 0)
            Console.WriteLine($"Divisão: {num1 / num2}");
        else
            Console.WriteLine("Não é possível dividir por zero.");

        Console.WriteLine($"Média: {(num1 + num2) / 2}");
        
        /*
         * 4.Crie um programa em que o usuário digita
         * uma ou mais palavras e é exibido a quantidade
         * de caracteres que a palavra inserida tem.
         */
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();
    
        int contador = 0;
        foreach (char c in texto)
        {
            if (c != ' ')
                contador++;
        }

        Console.WriteLine($"Quantidade de caracteres (sem espaços): {contador}");
        
        /*
         * 5. Crie um programa em que o usuário precisa digitar
         * a placa de um veículo e o programa verifica se a
         * placa é válida, seguindo o padrão brasileiro válido até 2018:
         *
         *  - A placa deve ter 7 caracteres alfanuméricos;
         *  - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
         *  - Os quatro últimos caracteres são números;
         *
         * Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
         */
        
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine().ToUpper();

        // Regex: 3 letras + 4 números
        bool valida = Regex.IsMatch(placa, @"^[A-Z]{3}[0-9]{4}$");

        Console.WriteLine(valida ? "Verdadeiro" : "Falso");
        
        /*
         * 6. Crie um programa que solicita ao usuário a exibição
         * da data atual em diferentes formatos:
         *
         *  - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
         *  - Apenas a data no formato "01/03/2024".
         *  - Apenas a hora no formato de 24 horas.
         *  - A data com o mês por extenso.
         */
        
        DateTime agora = DateTime.Now;

        Console.WriteLine("Formato completo: " + agora.ToString("F"));  
        Console.WriteLine("Apenas data: " + agora.ToString("dd/MM/yyyy"));  
        Console.WriteLine("Apenas hora (24h): " + agora.ToString("HH:mm:ss"));  
        Console.WriteLine("Data com mês por extenso: " + agora.ToString("dd 'de' MMMM 'de' yyyy"));

    }
}