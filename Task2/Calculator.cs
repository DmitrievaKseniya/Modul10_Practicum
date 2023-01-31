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
            int x = RequestNumber();
            int y = RequestNumber();
            Logger.Event($"Сумма введенных чисел равна: {x + y}");
        }

        public int RequestNumber()
        {
            int number = 0;
            while (true)
            {
                try
                {
                    Logger.Event("Введите число:");
                    Console.ForegroundColor = ConsoleColor.White;
                    number = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Logger.Error("Введено не корректное значение\n");
                }
            }
            return number;
        }
    }
}
