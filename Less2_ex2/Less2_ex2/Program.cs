using System;

namespace Less2_ex2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите номер месяца (1-12)");
            if (Int32.TryParse(Console.ReadLine(), out int month))
            {
                if (month <= 12 && month > 0)
                {
                    Console.WriteLine((Month)month);
                }
                else
                {
                    Console.WriteLine("Такого месяца не существует");
                    Console.ReadKey();
                }
            }
            else

            {
                Console.WriteLine("Введённый символ не соответствует номеру месяца");
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}