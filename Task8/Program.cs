using System;

namespace SEMINARDZ
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Введите целое число: ");
            string NumberStr = Console.ReadLine();
            int numberN = int.Parse(NumberStr);
            int numberF = 1;
            System.Console.WriteLine("Рандомное число: " + numberN);
            if (numberN>0)
            {
                System.Console.WriteLine("Список целых чётных чисел до искомого числа включительно:");
                while (numberF <= numberN)
                {
                    if (numberF > 0 & numberN > 0)
                    {
                        if (numberF %2 == 0)
                        {
                            System.Console.WriteLine(numberF);
                        }   
                    }
                numberF ++;
                }  
            }
            else
            {
                System.Console.WriteLine("Введите корректное число > 0");
            }      
        }    
    }  
}  
