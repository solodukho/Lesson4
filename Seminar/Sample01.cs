using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample01
    {

        static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static void Swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static bool DoProcess(out int a)
        {
            a = 10;
            return true;
        }

        static void Main(string[] args)
        {
            int m = 10;
            DoProcess(out m);

            int a = 5;
            int b = 3;

            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine();
            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine();
            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");

            Swap(a, b);

            Console.WriteLine();
            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");

            Swap(ref a, ref b);

            Console.WriteLine();
            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");

            Console.WriteLine();
            Console.Write("Введите первое целое число: ");
            int firstNumber = 2;
            if (int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine($"Вы ввели число: {firstNumber}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число.");
                Console.WriteLine("Завершение работы приложения...");
                Console.ReadKey(true);
                return;
            }

            Console.Write("Введите второе целое число: ");
            if (int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                Console.WriteLine($"Вы ввели число: {secondNumber}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число.");
                Console.WriteLine("Завершение работы приложения...");
                Console.ReadKey(true);
                return;
            }

            int max;
            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }

            // if - then - else

            Console.WriteLine($"Максимальное число: {max}");

            max = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine($"Максимальное число: {max}");

            Console.WriteLine("Максимальное число: {0}", firstNumber > secondNumber ? firstNumber : firstNumber);

            Console.WriteLine($"Максимальное число: {(firstNumber > secondNumber ? firstNumber : secondNumber)}");

            Console.WriteLine("{0} {1} {2} {3} {4}", 10, 'c', true, "abc", 10.5);

            int[] arr = new  int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine($"Сумма чисел: {Sum(arr)}");

            Console.ReadKey(true);
        }

        static int Sum(params int[] numbers)
        {
            int res = 0;
            foreach (int number in numbers)
            {
                res += number;
            }
            return res;
        }
    }
}
