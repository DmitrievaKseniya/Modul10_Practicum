using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    x = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введено не корректное значение\n");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите второе число:");
                    y = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введено не корректное значение\n");
                }
            }

            ICalculator calculator = new Calculator();
            calculator.Sum(x, y);
        }
    }

    public interface ICalculator
    {
        void Sum(int x, int y);
    }

    class Calculator : ICalculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"Сумма введенных чисел равна: {x + y}");
        }
    }
}
