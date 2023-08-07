using System;

namespace SEMINARDZ
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
            {
                System.Console.WriteLine("Число является чётным");
            }
            else
            {
                System.Console.WriteLine("Число не является чётным");
            }

        }
    }
}

