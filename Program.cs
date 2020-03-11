using System;
/*Написати програму, яка в консолі буде робити такий шаблон, як права частина трикутника і в рядочку будуть однакові числа.
1
22
333
4444*/

namespace HomeWork4Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }


        
     }
}