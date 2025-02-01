using System;

namespace NSConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandHi = "1";
            const string commandBye = "2";
            const string commandRandomNumber = "3";
            const string commandClearConsole = "4";
            const string commandExit = "5";

            Random random = new Random();
            bool isWork = true;
            int randomMinValue = 0;
            int randomMaxValue = 100;

            while (isWork)
            {
                Console.WriteLine($"Введите {commandHi}, чтобы вывести приветствие.");
                Console.WriteLine($"Введите {commandBye}, чтобы вывести прощание.");
                Console.WriteLine($"Введите {commandRandomNumber}, чтобы вывести случайное число.");
                Console.WriteLine($"Введите {commandClearConsole}, чтобы очистить консоль.");
                Console.WriteLine($"Введите {commandExit}, чтобы завершить работу.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case commandHi:
                        Console.WriteLine("Привет!");
                        break;

                    case commandBye:
                        Console.WriteLine("Прощай...");
                        break;

                    case commandRandomNumber:
                        Console.WriteLine(random.Next(randomMinValue, randomMaxValue));
                        break;

                    case commandClearConsole:
                        Console.Clear();
                        break;

                    case commandExit:
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