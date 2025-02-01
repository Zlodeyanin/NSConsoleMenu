using System;

namespace NSConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandHi = "1";
            const string CommandBye = "2";
            const string CommandRandomNumber = "3";
            const string CommandClearConsole = "4";
            const string CommandExit = "5";

            Random random = new Random();
            bool isWork = true;
            int randomMinValue = 0;
            int randomMaxValue = 100;

            while (isWork)
            {
                Console.WriteLine($"Введите {CommandHi}, чтобы вывести приветствие.");
                Console.WriteLine($"Введите {CommandBye}, чтобы вывести прощание.");
                Console.WriteLine($"Введите {CommandRandomNumber}, чтобы вывести случайное число.");
                Console.WriteLine($"Введите {CommandClearConsole}, чтобы очистить консоль.");
                Console.WriteLine($"Введите {CommandExit}, чтобы завершить работу.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandHi:
                        Console.WriteLine("Привет!");
                        break;

                    case CommandBye:
                        Console.WriteLine("Прощай...");
                        break;

                    case CommandRandomNumber:
                        Console.WriteLine(random.Next(randomMinValue, randomMaxValue));
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Такого пункта в меню нет.");
                        break;
                }
            }
        }
    }
}