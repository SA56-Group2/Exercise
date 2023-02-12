using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class E5
    {
        static void Main()
        {
            int num, j, start, end, count;
            Console.WriteLine("Enter the start number");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime number between " + start + " and " + end + " are:");
            for (num = start; num <= end; num++)
            {
                count = 0;

                for (j = 2; j <= num / 2; j++)
                {
                    if (num % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");

        }

        }
    }

