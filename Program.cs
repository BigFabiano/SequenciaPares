using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int num1;
            int i = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("┌────  Números Pares  ────┐");
            Console.ResetColor();

            Console.Write("   Digite um número: ");
            bool validaNumero = Int32.TryParse(Console.ReadLine(), out num1);

            if (!validaNumero)
            {
                Console.WriteLine("Número Invalido!");
            }
            while (i <= num1)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"  {  i } ");
                    Console.ResetColor();

                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Obrigado por usar o programa");
            Console.ReadKey();

        }
    }
}

