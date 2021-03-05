using System;
using System.Collections.Generic;
using System.Text;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Линейные алгоритмы";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string Ans;
            do
            {
                Console.Clear();
                try
                {
                    Console.Write("Введите x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    if (x != 2 / 3 && x > 0)
                    {
                        x = Math.Sqrt(Math.Pow(Math.E, x)) - Math.Abs(Math.Sin(Math.PI * x / (x + 2.0 / 3.0))) + 1.7;
                        Console.WriteLine("x = "+ x);
                    }
                    else
                        Console.WriteLine("x должен быть > 0 и не равен 2/3!");
                }
                catch (Exception)
                {
                    Console.Write("Введенные значеня некорректны! \n");
                }
                Console.Write("Повторим? ");
                Ans = Console.ReadLine();
            }
            while (Ans == "Y" || Ans == "y");
        }
    }
}
