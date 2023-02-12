using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F4
    {
        static void Main()
        {
            string sentence, conversion, finalword, convertedSentence="";

            Console.Write("Before Conversion: ");
            sentence = Console.ReadLine();
            string[] word= sentence.Split(' ');
               
            for(int i=0; i<word.Length; i++)
            {
                conversion = word[i];
                finalword = char.ToUpper(conversion[0]) + conversion.Substring(1) +" ";
                convertedSentence += finalword;
            }
            Console.WriteLine("After Conversion: "+convertedSentence);

        }
    }
    
}
