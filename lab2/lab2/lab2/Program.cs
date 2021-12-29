using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 1;
            byte a2 = 1;
            short a3 = 1;
            ushort a4 = 1;
            int a5 = 1;
            uint a6 = 1;
            long a7 = 1;
            ulong a8 = 1;
            float b1 = (float)1.111;
            double b2 = -1.1111;
            decimal b3 = (decimal)1111111.1111111;
            char c1 = 'a';
            string c2 = "abc";
            bool d1 = true;
            bool d2 = (1 > 2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
            Console.WriteLine(a7);
            Console.WriteLine(a8);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            string name = Console.ReadLine();
            string second_name = Console.ReadLine();
            short e1 = a2;
            int e2 = e1;
            long e3 = e2;
            long e4 = a1;
            int e5 = a3;
            short e6 = (byte)a2;
            short e7 = (sbyte)a1;
            int e8 = (byte)a2;
            int e9 = (sbyte)a1;
            long e10 = (short)a3;
            int e11 = Convert.ToInt32(a7);
            int a9 = 111;//создание переменной типа int
            int a10 = a9;//упаковка а9 в а10
            a10 = 111;
            a9 = (int)a10;//распаковка а10 в а9
            var a11 = 111;
            var c3 = "Привет";
            int? a12 = 111;
            if (a12.HasValue)
            {
                Console.WriteLine($"a12 имеет значение {a12.Value}");
            }
            else
            {
                Console.WriteLine($"а12 не имеет значения");
            }
            Console.ReadKey();
            var a13 = 111;
            //a13 = 'a';
            Console.WriteLine("Привет");
            Console.WriteLine("Как тебя зовут? \nКак дела?");
            string s1 = "Привет, как дела?";
            string s2 = "Как тебя зовут?";
            string s3 = "Откуда ты?";
            string s4 = s1 + s2;
            string s5 = String.Copy(s1);
            char index1 = 'а';
            int s6 = s2.LastIndexOf(index1);
            string phrase = "Привет как дела?";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
            string s7 = "Привет, ";
            string s8 = s7.Insert(7, "Антон");
            Console.WriteLine(s8);
            string s9 = "Привет, как дела?";
            s9.Remove(6, 11);
            int[,] array = new int[2, 2] { { 1, 1 }, { 2, 2 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }
            // var index = int.Parse(Console.ReadLine());
            //var value = int.Parse(Console.ReadLine());
            //array1[index] = value;
            //foreach (int i in array1)
            //{
            //  Console.WriteLine(i);
            //}
            ///////////////////////////////////////////
            int[][] array2 = new int[3][];
            int m1, m2, m3, m4, m5, m6, m7, m8, m9;
            m1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"m1 = {m1}");
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            m4 = int.Parse(Console.ReadLine());
            m5 = int.Parse(Console.ReadLine());
            m6 = int.Parse(Console.ReadLine());
            m7 = int.Parse(Console.ReadLine());
            m8 = int.Parse(Console.ReadLine());
            m9 = int.Parse(Console.ReadLine());
            array2[0] = new int[2] { m1, m2 };
            array2[1] = new int[3] { m3, m4, m5 };
            array2[2] = new int[4] { m6, m7, m8, m9 };
            ///////////////////////////////////////////
            var massiv = new object[0];
            var stroka = "";
            //кортежи
            (int, string, char, string, ulong) kortezh = (1, "string", 'c', "string2", 1);
            Console.WriteLine(kortezh.Item1);
            Console.WriteLine(kortezh.Item3);
            Console.WriteLine(kortezh.Item4);

            var (per1, per2, per3, per4, per5) = kortezh;
            Console.WriteLine(kortezh);
            Console.WriteLine(per1);
            Console.WriteLine(per2);
            Console.WriteLine(per3);
            Console.WriteLine(per4);
            Console.WriteLine(per5);
            //{
            //  var result = GetResult(new int[] { -3, -2, -1, 0, 1, 2, 3 });
            //Console.WriteLine(result);  // 6
            //Console.Read();
            //}
            Random rnd = new Random();
            Console.WriteLine();
            int[] random_arr = new int[5];
            for (int i1 = 0; i1 < random_arr.Length; i1++)
            {
                random_arr[i1] = rnd.Next() % 10;
                Console.Write(random_arr[i1] + " ");
            }
            string text = "Nihao";
            (int maximum, int minimum, int arr_sum, char first_symbol) function(int[] arr, string MyStr)
            {
                int maximum = int.MinValue;
                int minimum = int.MaxValue;
                int arr_sum = 0;
                foreach (var i1 in arr)
                {
                    if (i1 < minimum)
                    {
                        minimum = i1;
                    }
                    if (i1 > maximum)
                    {
                        maximum = i1;
                    }
                    arr_sum += i1;
                }
                return (maximum, minimum, arr_sum, MyStr[0]);
            }
            (int, int, int, char) five_task = function(random_arr, text);
            Console.WriteLine($"\nМаксимальный элемент массива: {five_task.Item1}\n" +
            $"Минимальный элемент массива: {five_task.Item2}\n" +
            $"Сумма элементов массива: {five_task.Item3}\n" +
            $"Первый символ строки: {five_task.Item4}\n");
            //6
            void CheckedFunction(int Num = int.MaxValue)
            {
                try
                {
                    Console.WriteLine($"{checked(Num + 1)}\n");
                    int New_Num = checked(Num + 1);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение(checked)\n");
                }
            }
            void UncheckedFunction(int Num = int.MaxValue)
            {
                try
                {
                    Console.WriteLine($"{unchecked(Num + 1)}\n");
                    int New_Num = unchecked(Num + 1);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение(unchecked)\n\n");
                }
            }
            CheckedFunction();
            UncheckedFunction();
        }
    }
}

