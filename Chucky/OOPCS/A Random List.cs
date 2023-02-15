using System;
using System.Collections.Generic;

namespace Class
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Let's start the game. Press any key to start");
            Console.ReadKey();
            Console.Write("Please enter the volumn of the numberlist: ");
            int numberV = int.Parse(Console.ReadLine());
            Console.Write("Please enter the lowest value: ");
            int numberL = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest value: ");
            int numberH = int.Parse(Console.ReadLine());
            RandomList myrandom = new RandomList();
            myrandom.seedValue = -9;
            int[] numberList = myrandom.Generate(numberV, numberL, numberH);
            myrandom.Show(numberList);
            myrandom.Mean(numberList);
        }
    }

    class RandomList
    {
        private int[] Arr;
        private int Lowvalue;
        private int Highvalue;
        private int i;
        public int seedValue
        {
            get { return i;}
            set { i = Math.Abs(value) > 10 ? 5 : value; }
        }

        public RandomList()
        {
            this.Arr = new int[] { 1, 2, 3, 4, 5 };
            this.Lowvalue = 1;
            this.Highvalue = 5;
            this.i = 5;
        }

        public int[] Generate(int n, int low, int high)
        {
            int[] numRan = new int[n];
            Random myRandom = new Random(this.i);
            for (int i = 0; i < n; i++)
            {
                numRan[i] = myRandom.Next(low, high - 1);
            }

            return numRan;
        }

        public void Show(int[] arr)
        {
            Console.Write("The numberlist is [");
            foreach (var num in arr)
            {
                Console.Write(num+" ");
            }
            Console.Write("]\n");
        }

        public double Mean(int[] arr)
        {
            double sum = 0;
            double avg;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToDouble(arr[i]);
            }
            avg = sum / arr.Length;
            Console.WriteLine("The mean of the numberlist is {0:f2}", avg);
            return avg;
        }
    }
}  
