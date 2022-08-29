using System;
using System.Threading;

namespace Stopwath
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite o tempo que deseja cronometrar: ");
            int seconds = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja contar em segundos ou minutos? ");
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            string data = Console.ReadLine().ToLower();

            Verify(data, seconds);

        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }

        static void Verify(string data, int seconds)
        {
            int multiplier = 60;
            if (data == "m")
            {
                int num = seconds * multiplier;
                Start(num);
                Menu();
            }
            else if (data == "s")
            {
                Start(seconds);
                Menu();
            }
            else
            {
                Console.WriteLine("Comando inválido, saindo...");
                System.Environment.Exit(0);
            }
        }
    }
}