//Составить программу нахождения произведения двух наименьших из трех различных чисел.
using System;
//то же, что и в фор и переделать тоже проверки

namespace FirstApp
{
    public class Logic
    {
        public static int[] FindTwoSmallest(int a, int b, int c)
        {
            int[] smallest = new int[2];

            if ((a < b && b < c) || (b < a && a < c))
            {
                smallest[0] = a;
                smallest[1] = b;
            }
            else if ((a < c && c < b) || (c < a && a < b))
            {
                smallest[0] = a;
                smallest[1] = c;
            }
            else
            {
                smallest[0] = b;
                smallest[1] = c;
            }

            return smallest;
        }

        public static int CalculateProduct(int[] numbers)
        {
            return numbers[0] * numbers[1];
        }

        public static bool IsDuplicate(int value, params int[] existingValues)
        {
            foreach (var existing in existingValues)
            {
                if (value == existing)
                    return true;
            }
            return false;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b;
            do
            {
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (Logic.IsDuplicate(b, a))
                    Console.WriteLine("Вы ввели повторяющиеся значения, пожалуйста, повторите попытку: ");

            } while (Logic.IsDuplicate(b, a));

            int c;
            do
            {
                Console.Write("Введите третье число: ");
                c = Convert.ToInt32(Console.ReadLine());

                if (Logic.IsDuplicate(c, a, b))
                    Console.WriteLine("Вы ввели повторяющиеся значения, пожалуйста, повторите попытку: ");

            } while (Logic.IsDuplicate(c, a, b));

            int[] smallestNumbers = Logic.FindTwoSmallest(a, b, c);
            int result = Logic.CalculateProduct(smallestNumbers);

            Console.WriteLine("Ваш набор чисел: " + a + ", " + b + ", " + c);
            Console.WriteLine("Наименьшие числа: " + smallestNumbers[0] + ", " + smallestNumbers[1]);
            Console.WriteLine("Произведение двух чисел: " + smallestNumbers[0] + " * " + smallestNumbers[1] + " = " + result);
        }
    }
}


//Console.Write("Введите первое число: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int b;
//int c;
//int min1;
//int min2;
//int result;

//do
//{
//    Console.Write("Введите второе число: ");
//    b = Convert.ToInt32(Console.ReadLine());
//    if (a == b)
//        Console.WriteLine("Вы ввели повторяющиеся значения, пожалуйста, повторите попытку: ");
//} while (a == b);
//do
//{
//    Console.Write("Введите третье число: ");
//    c = Convert.ToInt32(Console.ReadLine());
//    if (a == c || b == c)
//        Console.WriteLine("Вы ввели повторяющиеся значения, пожалуйста, повторите попытку: ");
//} while (a == c || b == c);

//if ((a < b && b < c) || (b < a && a < c))
//{
//    min1 = a;
//    min2 = b;
//    result = a * b;
//}
//else if ((a < c && c < b) || (c < a && a < b))
//{
//    min1 = a;
//    min2 = c;
//    result = a * c;
//}
//else
//{
//    min1 = b;
//    min2 = c;
//    result = b * c;
//}
//Console.WriteLine("Ваш набор чисел: " + a + ", " + b + ", " + c);
//Console.WriteLine("Наименьшие числа: " + min1 + ", " + min2);
//Console.WriteLine("Произведение двух чисел: " + min1 + " * " + min2 + " = " + result);