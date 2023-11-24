using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("M = Milisegundo => 10m");
            Console.WriteLine("S = Segundo => 10s");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quando tempo deseja contas?");

            string choice = Console.ReadLine().ToLower();

            if (choice == "0") Environment.Exit(0);

            char type = char.Parse(choice.Substring(choice.Length - 1, 1));
            int time = int.Parse(choice[..^1]);

            if (time == 0) Environment.Exit(0);

            PreStart(time, type);
        }

        static void Start(int time, char type)
        {
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                if (type == 'm')
                    Thread.Sleep(1);
                else
                    Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }

        static void PreStart(int time, char type)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time, type);
        }
    }
}
