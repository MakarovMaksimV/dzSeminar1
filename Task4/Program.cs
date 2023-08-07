using System;

namespace SEMINARDZ
{
    class SEMINARDZ
    {
        static void Main()
        {
            int number1 = new Random().Next(0, 999);
            int number2 = new Random().Next(0, 999);
            int number3 = new Random().Next(0, 999);
            System.Console.WriteLine("Получим два рандомных чилса: " + number1 + ", " + number2 + ", " + number3);
            System.Console.WriteLine("Максимальное число: " + Math.Max(number1, Math.Max(number2, number3)));
        }    
    }

    
}    