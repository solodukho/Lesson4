using System;

namespace Homework4
{
    class Program
    {
        /// <summary>
        /// Написать метод GetFullName(string firstName, string lastName, string patronymic), 
        /// принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.    
        /// Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        /// </summary>
        static void Task1()
        {
            GetFullName("Иванов", "Иван", "Иванович");
            GetFullName("Петров", "Пётр", "Петрович");
            GetFullName("Алексеев", "Алексей", "Алексеевич");
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1 'Написать программу, выводящую объединённую строку с ФИО.'");
                Console.WriteLine("2 -> Задача 2 'телефонный справочник — создать двумерный массив 5 * 2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона / e - mail.'");
                Console.WriteLine("3 -> Задача 3 'Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).'");
                Console.WriteLine("4 -> Задача 4 '* «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки'");
                Console.WriteLine("0 -> 'Завершение работы приложения'");
                Console.WriteLine("=================================");

                Console.Write("Введите номер задачи: ");
                int number = int.TryParse(Console.ReadLine(), out number) ? number : 0;

                switch (number)
                {
                    case 1:
                        Task1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Task2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Task3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Task4();
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Некорректный номер задачи,\nповторите попытку ввода ...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
