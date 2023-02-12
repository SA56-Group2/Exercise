using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F2
    {
        static void Main()
        {
            string fowardstr, reversestr = string.Empty;
            Console.Write("Enter a string : ");
            fowardstr = Console.ReadLine();
            if (fowardstr != null)
            {
                for (int i = fowardstr.Length - 1; i >= 0; i--)
                {
                    reversestr += fowardstr[i].ToString();
                }
                if (reversestr == fowardstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", fowardstr, reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", fowardstr, reversestr);
                }
            }

        }
    }
}
