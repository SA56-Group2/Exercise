using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class E4
    {
        static void Main()
        {
            int number, perfectNumber = 0;
            Console.WriteLine("Please Enter a Number");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    perfectNumber += i;
                }
            }
            if (number == perfectNumber/2)
            {
                Console.WriteLine(number + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(number + " is not a Perfect Number");
            }
        }
    }
}
