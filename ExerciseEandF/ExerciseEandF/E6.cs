using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class E6
    {
        static void Main()
        {
            int sum;

            for(int i = 1; i < 100; i++)
            {
                sum = 0;

                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i + " is Perfect Number");
                }


            }

        }
    }
}
