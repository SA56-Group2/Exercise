using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class E3
    {
        static void Main()
        {

            int number, count=0;
            Console.WriteLine("Enter A Number");
            number = int.Parse(Console.ReadLine());

            /*            for (int i = 1; i <= number; i++)
                        {
                            if (number % i == 0)
                            {
                                count++;
                            }
                        }
                        if (count == 2)
                        {
                            Console.WriteLine(number + " is a Prime Number");
                        }
                        else
                        {
                            Console.WriteLine(number + " is not a Prime Number");
                        }*/

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    count++;
                    break;
 
                }
            }

                if (count == 0 && number != 1)
                {
                    Console.WriteLine(number + " is a Prime Number");
                }
                else
                {
                    Console.WriteLine(number + " is not a Prime Number");
                }


        }
    }
}
