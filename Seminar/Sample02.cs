using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample02
    {
        static void Main(string[] args)
        {
            char[] chars =
            {
                'j',
                '\u006A',
                (char)106
            };
            Console.WriteLine(String.Join(" ", chars));
            Console.ReadKey(true);
            char symbol01 = 'a';
            Console.WriteLine($"{symbol01} {char.ToUpper(symbol01)}");
            UnicodeCategory category = char.GetUnicodeCategory('+');


            int a = 1;
            int b = 2;

            if (a == b)
            {

            }

            string str01;
            str01 = "Hello, GeekBrains!";
            //str01 = "Hello!";
            string str02 = "";
            string str03 = string.Empty;
            string str04 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            string str05 = new string('a', 10);

            string str06 = "Hello, GeekBrains!";

            Console.WriteLine(str01 == str06); // ==
            Console.WriteLine(str01.Equals(str06));

            MyString myString01 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString myString02 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });

  
    

            Console.WriteLine(myString01 == myString02); // ==
            Console.WriteLine(myString01.Equals(myString02));

            Console.WriteLine(str06);
            Console.WriteLine(myString02);


            string message = "За окном потоп, а я ем торт.";
            PrintWords(message);

            Console.ReadKey(true);
        }

        static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                //string str = words[i];
                //char c = str[0];
                //char c2 = words[i][0];
                //int l = str.Length - 1;
                //c2 = words[i][words[i].Length -1 ];

                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }
        }


    }

    class MyString
    {
        private char[] arr;

        public MyString(char[] arr)
        {
            this.arr = arr;
        }

        public static bool operator == (MyString o1, MyString o2)
        {
            return o1.Equals(o2);
        }

        public static bool operator !=(MyString o1, MyString o2)
        {
            return !o1.Equals(o2);
        }

        public override string ToString()
        {
            return new string(arr);
        }

        public override bool Equals(object obj)
        {
            if (obj is MyString)
            {
                MyString myString = (MyString)obj;
                if (this.arr.Length != myString.arr.Length)
                    return false;
                for (int i = 0; i < this.arr.Length; i++)
                {
                    if (this.arr[i] != myString.arr[i])
                    return false;
                }

                return true;
            }
            return false;
        }

    }

}
