﻿using System;

namespace SEMINARDZ
{
    class Program
    {
        static void Main()
        {
            int number1 = new Random().Next(0, 999);
            int number2 = new Random().Next(0, 999);
            System.Console.WriteLine("Получим два рандомных числа: " + number1 + ", " + number2);
            System.Console.WriteLine("Максимальное число: " + Math.Max(number1,number2) + ". Минимальное число: " + Math.Min(number1,number2));
        }

    }  
}




