using System;

namespace Lab_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                double a, b;
                string operation;

                try
                {
                    Console.WriteLine("Введите число 1");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                    continue;
                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        if (b == 0)
                        {
                        Console.WriteLine("Ошибка");
                        }
                        else
                        {
                        Console.WriteLine(a / b);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

            }
        }
    }
}
