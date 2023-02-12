
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F3
    {
        static void Main()
        {


            string sentence,fowardstr, reversestr = string.Empty;
            StringBuilder sb = new StringBuilder();
            Console.Write("Enter a string : ");
            sentence = Console.ReadLine();
            foreach (char c in sentence)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {  
                    sb.Append(char.ToLower(c));
                }
            }
            fowardstr = sb.ToString();
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

