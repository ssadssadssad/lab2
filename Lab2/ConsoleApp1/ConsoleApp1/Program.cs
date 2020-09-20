using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            while (x != 0)
            {
                Console.WriteLine("Input number of task");
                x = Convert.ToInt16(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        TaskOne();
                        break;
                    case 2:
                        TaskTwo();
                        break;
                    case 3:
                        TaskThree();
                        break;
                    case 4:
                        TaskFour();
                        break;
                    case 5:
                        int[] ar6 = {3, 455, 22, 266, 18, 77, 57};
                        string str8 = "Please";
                        Console.WriteLine(TaskFive(ar6, str8));
                        break;
                    case 6:
                        TaskSixFirst();
                        TaskSixSecond();
                        break;
                    default:
                        return;
                }
            }
            (int, int, int, char) TaskFive(int[] ar, string str)
            {
                int max, min, eq = 0;
                max = min = ar[0];
                foreach (int i in ar)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                foreach (int i in ar)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                foreach (int i in ar)
                {
                    eq += i;
                }
                (int, int, int, char) tuple3 = (max, min, eq, str[0]);
                return tuple3;
            }
            void TaskSixFirst()
            {
                checked
                {
                    int ch = 2147483647;
                    
                    Console.WriteLine(ch);
                }
            } 
            void TaskSixSecond()
            {
                unchecked
                {
                    int unch = 2147483647;
                    Console.WriteLine(unch);
                }
            }
        }
        static void TaskOne()
        {
            bool q1 = true;
            byte q2 = 3;
            sbyte q3 = -3;
            char q4 = 'f';
            decimal q5 = 300;
            double q6 = 200.4;
            float q7 = 3.6f;
            int q8 = 255;
            uint q9 = 256;
            long q10 = 555;
            ulong q11 = 556;
            short q12 = 222;
            ushort q13 = 223;
            string q14 = "afsafa";
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}", q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14);
            int num1 = 2147;
            long bigNum1 = num1;
            float num2 = 134.45f;
            double bigNum2 = num2;
            byte num3 = 5;
            short bigNum3 = num3;
            long num4 = 87;
            decimal bigNum4 = num4;
            ushort num5 = 56;
            int bigNum5 = num5;
            int smallNum1 = (int)bigNum2;
            long smallNum2 = (long)bigNum4;
            decimal smallNum3 = (decimal)num2;
            short smallNum4 = (short)bigNum5;
            uint smallNum5 = (uint)bigNum1;
            int price = 39;
            Object obj = price;
            int price2 = (int)obj;
            var f = 0.34F;
            double? d1 = 3.3;
            var j = 3;
            //j = 0.34F;
            int n = Convert.ToInt32(num5);
        }
        static void TaskTwo()
        {
            if("gh" != "bb")
            {
                Console.WriteLine("Литералы");
            }
            string str1 = "legend is good";
            string str2 = "glory dinner";
            string str3 = "smell of victory";
            string str4 = str1 + " " + str2;
            Console.WriteLine(str4);
            string str5 = string.Copy(str3);
            Console.WriteLine(str3);
            string str6 = str1.Substring(3, 3);
            Console.WriteLine(str6);
            string[] split = str1.Split(' ');
            foreach (string s in split)
            {
                Console.WriteLine(s);
            }
            str1 = str1.Insert(10, "not ");
            Console.WriteLine(str1);
            str1 = str1.Remove(10, 4);
            Console.WriteLine(str1);
            string str7 = "taste";
            Console.WriteLine($"Good {str7}");
            string testStr1 = " ";
            string testStr2 = null;
            Console.WriteLine(String.IsNullOrEmpty(testStr1) + " ' '");
            Console.WriteLine(String.IsNullOrEmpty(testStr2) + "null");
            Console.WriteLine(String.IsNullOrWhiteSpace(testStr1) + " ' '");
            Console.WriteLine(String.IsNullOrWhiteSpace(testStr2) + " null");
            StringBuilder strB1 = new StringBuilder("StringBuilder");
            strB1.Remove(0, 3);
            strB1.Remove(7, 3);
            Console.WriteLine(strB1);
            strB1.Insert(0, "Str");
            strB1.Insert(10, "der");
            Console.WriteLine(strB1);
        }
        static void TaskThree()
        {
            int[,] ar1 = new int[2, 2];
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar1[i, j] = Convert.ToInt16(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}  ", ar1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив строк:");
            string[] ar2 = {"Hello", "world", "good", "bad", "hard"};
            foreach (string str in ar2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Длина массива строк {0}", ar2.Length);
            Console.WriteLine("Номер изменяемого элемента масссива строк: ");
            int numberOfChange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Новый элемент массива строк: ");
            string newElement = Console.ReadLine();
            ar2[numberOfChange - 1] = newElement;
            Console.WriteLine("Новый массив строк: ");
            foreach (string str in ar2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Ступенчатый массив:");
            int[][] ar3 = new int[3][];
            ar3[0] = new int[2];
            ar3[1] = new int[3];
            ar3[2] = new int[4];

            for (int i = 0; i < 3; i++)
            {
                int g = 0;
                foreach (int tmp in ar3[i])
                {
                    ar3[i][g] = Convert.ToInt32(Console.ReadLine());
                    g++;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int g = 0;
                foreach (int tmp in ar3[i])
                {
                    Console.Write(" " + ar3[i][g]);
                    g++;
                }
                Console.WriteLine();
            }
            var ar4 = new int[10];
            var ar5 = "String";
        }
        static void TaskFour()
        {
            (int, string, char, string, ulong) tuple1 = (10, "String1", 'W', "String2", 170);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item2);
            Console.WriteLine(tuple1.Item3);
            var (_, _, _, _, fifth) = tuple1;
            (int, string, char, string, ulong) tuple2 = (20, "String1", 'W', "String2", 270);
            if (tuple1 == tuple2)
            {
                Console.WriteLine("Кортеж 1 и кортеж 2 равны");
            }
            else
            {
                Console.WriteLine("Кортеж 1 и кортеж 2 не равны");
            }
        }
        static void TaskSix()
        {

        }
    }
}
