using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class E1
    {
        static void Main(string[] args)
        {
            int factorial=1, number;
            string displayIncrease=null;
            string displayDecrease=null;

            Console.WriteLine("Please Enter a number for increasing order: ");
            number = int.Parse(Console.ReadLine());
            for(int i=1; i <= number; i++)
            {
                factorial = factorial * i;
                displayIncrease = displayIncrease + "*" + i.ToString();
            }
            Console.WriteLine("The Factorial of " + number + " in increasing order: " + displayIncrease.Substring(1)+" = "+factorial);

            Console.WriteLine("Please Enter a number for decreasing order: ");
            number = int.Parse(Console.ReadLine());

            factorial = 1;
            for (int i = number; i >0; i--)
            {
                factorial = factorial * i;
                displayDecrease = displayDecrease + "*" + i.ToString();
            }
            Console.WriteLine("The Factorial of " + number + " in decreasing order: " + displayDecrease.Substring(1) + " = " + factorial);


        }
    }
}
