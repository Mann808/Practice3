using System;
namespace Practich3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");
            int n = 0;
            int x;
            while (n == 0)
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Program1();
                        break;
                    case 2:
                        Program2();
                        break;
                    case 3:
                        Program3();
                        break;
                    case 4:
                        Console.WriteLine("До свидания");
                        n = 1;
                        break;
                        default: Console.WriteLine("Выбранной программы не существет");
                        break;
                }
            }
        }
        static void Program1()
        {
            Console.WriteLine("Угадай число!");
            Random a = new Random();
            int otvet = a.Next(101);
            while (true)
            {
                Console.WriteLine("Введите число");

                int chislo = Convert.ToInt32(Console.ReadLine());

                if (chislo == otvet)
                {
                    Console.WriteLine("Вы угадали:" + chislo);

                    break;
                }
                else if (chislo > otvet)
                {
                    Console.WriteLine("Ваше число больше");
                }
                else
                {
                    Console.WriteLine("Ваше число меньше");
                }

            }
        }
        static void Program2()
        {
            Console.WriteLine("Таблица умножения: ");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i * j);
                    Console.Write(j != 9 ? ' ' : '\n');
                }

            }
        }
        static void Program3()
        {
            Console.Write("Введи число ");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int deli = 1; deli <= del; deli++)
            {
                if (del % deli == 0) Console.Write("{0} ", deli);
            }
        }
    }
}