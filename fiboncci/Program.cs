// C#
using System;

class Program
{
    static void Main()
    {
        // Lê o número informado pelo usuário
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Calcula a sequência de Fibonacci e verifica se o número pertence a ela
        bool pertence = VerificarSePertence(numero);

        // Imprime o resultado
        if (pertence)
        {
            Console.WriteLine("O número {0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("O número {0} não pertence à sequência de Fibonacci.", numero);
        }
    }

    static bool VerificarSePertence(int numero)
    {
        int a = 0;
        int b = 1;

        while (b <= numero)
        {
            if (b == numero)
            {
                return true;
            }

            int proximo = a + b;
            a = b;
            b = proximo;
        }

        return false;
    }
}
