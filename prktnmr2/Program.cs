using System;
using System.Linq;

namespace prktnmr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ///////////////////////////
            Console.WriteLine("Задание 1: функция, которая принимает два целых числа и возвращает их сумму.\n\nВведите 2 числа");

            int zd1a = Convert.ToInt32(Console.ReadLine());
            int zd1b = Convert.ToInt32(Console.ReadLine());

            int zd1func(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine("Вывод: " + zd1func(zd1a, zd1b));

            /////////////////////////////////

            Console.WriteLine("\nЗадание 2: функция, которая принимает радиус окружности и возвращает ее площадь\n\nВведите радиус");

            double zd2rad = Convert.ToDouble(Console.ReadLine());

            double zd2plshokrg(double a)
            {
                return Math.PI * (a * a);
            }

            Console.WriteLine("Вывод: " + zd2plshokrg(zd2rad));

            ////////////////////////////////////

            Console.WriteLine("\nЗадание 3: функция, которая принимает строку и возвращает ее длину\n\nВведите строку");

            string zd3str = Console.ReadLine();

            int zd3strlngt(string a)
            {
                return a.Length;
            }

            Console.WriteLine("Вывод: " + zd3strlngt(zd3str));

            /////////////////////////////////////

            Console.WriteLine("\nЗадание 4: функция, которая принимает массив целых чисел и возвращает наибольшее значение в массиве\n\nВведите 5 чисел");

            int[] zd4arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                zd4arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int zd4fndmxvl(int[] arr)
            {
                int maxValue = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > maxValue)
                    {
                        maxValue = arr[i];
                    }
                }

                return maxValue;
            }

            Console.WriteLine("Вывод: " + zd4fndmxvl(zd4arr));

            ///////////////////////////////////

            Console.WriteLine("\nЗадание 5: Функция, которая принимает число и возвращает его факториал\n\nВведите число");

            long zd5a = Convert.ToInt64(Console.ReadLine());

            long zd5fak(long number)
            {
                long result = 1;
                for (long i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }

            Console.WriteLine("Вывод: " + zd5fak(zd5a));

            /////////////////////////////////

            Console.WriteLine("\nЗадание 6: функция, которая принимает строку и проверяет, является ли она палиндромом\n\nВведите строку");

            string zd6strng = Console.ReadLine();

            bool zd6ispoly(string i)
            {
                string reverse = new string(i.ToCharArray().Reverse().ToArray());
                if (i.Equals(reverse))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("Вывод: " + zd6ispoly(zd6strng));

            //////////////////////////////////////

            Console.WriteLine("\nЗадание 7: функция, которая принимает два массива целых чисел и возвращает новый массив, содержащий элементы обоих массивов\n\nВведите первый массив (5)");

            int[] zd7arr1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                zd7arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nВведите второй массив (5)");

            int[] zd7arr2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                zd7arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            string zd7func(int[] x, int[]y)
            {
                return string.Join(", ", x.Concat(y).ToArray());
            }

            Console.WriteLine("Вывод: " + zd7func(zd7arr1, zd7arr2));

            ////////////////////////////

            Console.WriteLine("\nЗадание 8: Функция, которая принимает число и возвращает true, если оно простое, и false в противном случае\nВведите число");

            int zd8int = Convert.ToInt32(Console.ReadLine());

            bool zd8isprime(int a)
            {
                if (a <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            Console.WriteLine("Вывод: " + zd8isprime(zd8int));

            /////////////////////////////////
            
            Console.WriteLine("\nЗадание 9: функция, которая принимает строку и возвращает ее в обратном порядке\n\nВведите строку");

            string zd9strng = Console.ReadLine();

            string zd9ispoly(string i)
            {
                return new string(i.ToCharArray().Reverse().ToArray());
            }

            Console.WriteLine("Вывод: " + zd9ispoly(zd9strng));

            ////////////////////////////????

            Console.WriteLine("\nЗадание 10: функция, которая принимает двумерный массив чисел и возвращает сумму всех элементов\n\nВведите введите двумерный массив числел (3 на 3)");

            int[,] zd10arr1 = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("------");
                for (int j = 0; j < 3; j++)
                {
                    zd10arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int zd10sum(int[,] z)
            {
                {
                    int sum = 0;
                    foreach (int num in z)
                    {
                        sum += num;
                    }
                    return sum;
                }
            }

            Console.WriteLine("Вывод: " + zd10sum(zd10arr1));
        }
    }
}
