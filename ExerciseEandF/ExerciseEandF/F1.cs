using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F1
    {
        static void Main()
        {
            string upperword,word;
            int count = 0, av=0, ev = 0, iv = 0, ov = 0, uv = 0;
            Console.WriteLine("Please Enter a Sentence.");
            word= Console.ReadLine();
            upperword= word.ToUpper();
            Console.WriteLine(upperword);
            for(int i =0; i< upperword.Length;i++)
            {

                switch (upperword[i])
                {
                    case 'A': 
                        av++;
                        count++;
                        break;
                    case 'E':
                        ev++;
                        count++;
                        break;
                    case 'I':
                        iv++;
                        count++;
                        break;
                    case 'O':
                        ov++;
                        count++;
                        break;
                    case 'U':
                        uv++;
                        count++;
                        break; 
                    default:
                    break;


                }
  
            }
            Console.WriteLine("There are " +count + " vowels in your word:");
            Console.WriteLine("A: " + av);
            Console.WriteLine("E: " + ev);
            Console.WriteLine("I: " + iv);
            Console.WriteLine("O: " + ov);
            Console.WriteLine("U: " + uv);

        }
    }
}
