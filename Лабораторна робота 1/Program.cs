using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name="Даша";
            int age = 17;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("task 1");
            Console.WriteLine("Мене звати {0}, мені {1} років", name, age);


            //task 2
            int a = 3;
            int b = 9;
            double result;

            result = (Math.Pow((a + b), 4) -( Math.Pow(a, 4) + 4 * Math.Pow(a, 3) * b )) / (6 * Math.Pow(a, 2) * Math.Pow(b, 2) + 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4));
            Console.WriteLine("-----------------");
            Console.WriteLine("task 2");
            Console.WriteLine($"result={result}");


            //task 3
            int number, num1, num2, num3,resultat;
            Console.WriteLine("-----------------");
            Console.WriteLine("task 3");
            Console.WriteLine("Введіть трьохзначне число");
            number = Convert.ToInt32(Console.ReadLine()) ;
            //take 1 number
            num1 = number / 100; //поділимо на 100,щоб отримати першу цифру числа без залишку
            num3 = number % 10; // % означає,що ми знаходимо залишок при діленні на 10.Тобто,якщо число 123 поділимо на 10,то завдяки % отримаємо третю цифру.
            num2 = (number - num1 * 100) / 10;// віднімаємо від числа першу цифру помножену на 100,отримуємо число без першої цифри і ділимо на 10 без залишку
            resultat = num3*100 + num2 * 10 + num1 ;
            Console.WriteLine(resultat);
            Console.ReadKey();
        }
    }
}

