using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator (ILogger logger)
        {
            Logger = logger;
        }

        public void Sum()
        {
            int x = 0, y = 0;
            while (true)
            {
                try
                {
                    Logger.Event("Введите первое число:");
                    Console.ForegroundColor = ConsoleColor.White;
                    x = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Logger.Error("Введено не корректное значение\n");
                }
            }

            while (true)
            {
                try
                {
                    Logger.Event("Введите второе число:");
                    Console.ForegroundColor = ConsoleColor.White;
                    y = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Logger.Error("Введено не корректное значение\n");
                }
            }

            Logger.Event($"Сумма введенных чисел равна: {x + y}");
        }
    }
}
