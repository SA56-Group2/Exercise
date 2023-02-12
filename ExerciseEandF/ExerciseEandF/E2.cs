using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExerciseEandF
{
    internal class E2
    {
        static void Main()
        {
            double[] number = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] inverse = new double[10];
            double[] squareRoot = new double[10];
            double[] square = new double[10];
            Console.WriteLine("NO \t INVERSE \t SQUAREROOT \t SQUARE");
            Console.WriteLine("----------------------------------------------------");
            for(int i=0; i<number.Length; i++)
            {
                inverse[i] = number[i] / (number[i] * number[i]);
                squareRoot[i] = Math.Sqrt(number[i]);
                square[i] = Math.Pow(number[i],2);
                Console.WriteLine($"{number[i]} \t {inverse[i]:0.00} \t\t {squareRoot[i]:0.00} \t {square[i]}");

            }

        }
    }
}
