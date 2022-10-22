using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число: ");
            var cal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            var cal2 = int.Parse(Console.ReadLine());

            var cal = new LibCal.Class1();

            Console.WriteLine($"Сумма двух чисел {cal1} + {cal2} = {cal.Sum(cal1, cal2)}");

        }
    }
}
