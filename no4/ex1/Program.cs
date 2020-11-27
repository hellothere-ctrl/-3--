using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Александрова Валерия. Задание 1.
            //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

            int a = 0;
            int b = 0;

            do
            {
                b = int.TryParse(Console.ReadLine());
                if (b > 0 && return (b & 1) == 0)
                        a += b;

            } while (b != 0);

            Console.WhiteLine("Сумма чисел равна: " + a);

            //не очень понял с tryparse, но должно быть как
            // double.TryParse (a, out a); ?


        }
    }
}
