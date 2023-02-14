using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace Quiz_slu
{
    class Day5Quiz
    {
        static void Main()
        {
            Console.WriteLine("1 for G1\t2 for G2\t3 for G3\t4 for H1\t 5 for H2\t6 for H3");
            Console.WriteLine("7 for H4\t8 for H5\t9 for H6\t10 for H7\t 0 for Exit");
            int textNumber = int.Parse(Console.ReadLine());
            switch (textNumber)
            {
               case 1:
               {
                   G1exercise();
                   Main();
                   break;
               }
               case 2:
               {
                   G2exercise();
                   Main();
                   break;
               }
               case 3:
               {
                   G3exercise();
                   Main();
                   break;
               }
               case 4:
               {
                   H1exercise();
                   Main();
                   break;
               }
               case 5:
               {
                   H2exercise();
                   Main();
                   break;
               }
               case 6:
               {
                   H3exercise();
                   Main();
                   break;
               }
               case 7:
               {
                   H4exercise();
                   Main();
                   break;
               }
               case 8:
               {
                   H5exercise();
                   Main();
                   break;
               }
               case 10:
                   H7execise();
                   Main();
                   break;
            }
            
        }

        public static void G1exercise()
        {
            Console.WriteLine("Please enter the monthly number.");
            int[] sales = new int[12];
            for (int i = 0; i < 12; i++)
            {
                Console.Write("The sales in Month {0}: ",i+1); 
                sales[i] = int.Parse(Console.ReadLine());
            }

            int sum =0;
            double avg = 0.00;
            int max = 0;
            int min = 0;
            for (int i = 0; i < 11; i++)
            {
                max = Math.Max(sales[i], sales[i + 1]);
            }
            Console.WriteLine("The max in this year is: {0:f2}",max);
            for (int i = 11; i >0; i--)
            {
                min = Math.Min(sales[i], sales[i - 1]);
            }
            Console.WriteLine("The min in this year is: {0:f2}",min);
            foreach (int sale in sales)
            {
                sum += sale;
                avg = Convert.ToDouble(sum) / 12;
            }
            Console.WriteLine("The avg in this year is: {0:f2}",avg);
        }

        public static void G2exercise()
        {
            Console.WriteLine("Please write the number you like just as the following format (XX XX XX)");
            string number = Console.ReadLine();
            string[] numbers = number.Split(' ');
            List<double> numArray = new List<double>();
            foreach (var num in numbers)
            {
                double a = Convert.ToDouble(num);
                numArray.Add(a);
            }
            numArray.Sort();
            numArray.Reverse();
            Console.Write("The number in descending order is ");
            foreach (var num1 in numArray)
            {
                Console.Write($"{num1}  ");
            }
            Console.WriteLine();
        }

        public static void G3exercise()
        {
            Console.Write("Please enter the numbers of subjects in one class: ");
            int rowNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the numbers of student in one class: ");
            int colNum = int.Parse(Console.ReadLine());
            object[,] studentS = new Object[colNum+3, rowNum+3];
            
            Random myRadom = new Random();
            for (int i = 0; i < colNum+1; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < rowNum+1; k++)
                    {
                        string sub = "sub" + k;
                        Console.Write(sub+"\t");
                    }

                    Console.WriteLine();
                }
                else if(i > 0)
                {
                    for (int j = 0; j < rowNum+1; j++)
                    {
                        if (j == 0)
                        {
                            string name = "stu" + i;
                            Console.Write(name+"\t");
                        }
                        else if (j > 0)
                        {
                            studentS[i, j] = myRadom.Next(0, 10000) / 100;
                            Console.Write($"{studentS[i,j]}\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total marks obtained each student.");
            double sum = 0;
            double avg = 0;
            for (int i = 1; i < colNum+1; i++)
            {
                for (int j = 1; j < rowNum+1; j++)
                {
                    sum += Convert.ToDouble(studentS[i, j]);
                }
                avg = sum / rowNum;
                Console.WriteLine("The total - avg of student{0}: {1:f2} , {2:f2}",i+1,sum,avg);
                sum = 0;
                avg = 0;
            }
            
            for (int i = 1; i < rowNum+1; i++)
            {
                for (int j = 1; j < colNum+1; j++)
                {
                    sum += Convert.ToDouble(studentS[j, i]);
                }
                avg = sum / colNum;
                double me = 0;
                double sum1 = 0;
                double avg1 = 0;
                for (int k = 1; k < colNum+1; k++)
                {
                    sum1 += (Convert.ToDouble(studentS[k, i])-avg)*(Convert.ToDouble(studentS[k, i])-avg);
                }
                avg1 = sum1 / colNum;
                avg1 = Math.Sqrt(avg1);
                Console.WriteLine("The total - avg - std of sub{0}: {1:f2} , {2:f2} , {3:f3}",i,sum,avg,avg1);
                sum = 0;
                avg = 0;
                sum1 = 0;
                me = 0;
            }

            double avgMark = 0;
            double totalMark = 0;
            double mul = Convert.ToDouble(rowNum * colNum);
            for (int i = 1; i < colNum+1; i++)
            {
                for (int j = 1; j < rowNum+1; j++)
                {
                    totalMark += Convert.ToDouble(studentS[i, j]);
                }
                avgMark = totalMark / mul;
                if (i == colNum)
                {
                    Console.WriteLine("The avg for the class is :{0:f2}",avgMark);
                }
            }
        }

        public static void H1exercise()
        {
            bool isNumber = false;
            do
            {
                Console.Write("Please enter a number: ");
                string number = Console.ReadLine();
                Regex regex = new Regex("^[0-9]*$");
                isNumber = regex.IsMatch(number);
                if (isNumber == true)
                {
                    Console.WriteLine($"Your input is {number}");
                    break;
                }
                else Console.WriteLine("Please input again.");
            }while(isNumber==false);
            
            
        }

        public static void H2exercise()
        {
            Console.Write("Please enter a series of numbers: ");
            int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7 };
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write($"{number}"+" ");
            }
            Console.WriteLine();
        }

        public static void H3exercise()
        {
            Console.Write("Please enter a word: ");
            string s = Console.ReadLine();
            Console.Write("Please enter a replaced letter: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a substituted letter: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            string s3 = Substitute(s, c1, c2);
            Console.WriteLine("The final word is: {0}",s3);
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string[] stringC1 = s.Split(c1);
            if (stringC1[1] is string)
            {
                s.Replace(c1, c2);
                return s;
            }
            else
            {
                string result = "There is no matched letter to replace.";
                return result;
            }
        }

        public static void H4exercise()
        {
           Console.Write("Please enter the a series of numnber (using this format XX XX XX): ");
           string numnber = Console.ReadLine();
           string[] numbers = numnber.Split(' ');
           int[] arr = new int[numbers.Length];
           for (int i = 0; i <numbers.Length; i++)
           {
               arr[i] =  Convert.ToInt32(numbers[i]);
           }
           Console.Write("Please make sure the value you want to add: ");
           int value = int.Parse(Console.ReadLine());
           int[] arr1 = SetArray(arr, value);
           Console.Write("The final numbers are : ");
           for (int i = 0; i < arr1.Length; i++)
           {
               Console.Write($"{arr1[i]}  ");
           }
           Console.WriteLine();
        }

        public static int[] SetArray(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += value;
            }
            return arr;
        }

        public static void H5exercise()
        {
            Console.Write("Please enter the a series of numnber (using this format XX XX XX): ");
            string numnber = Console.ReadLine();
            string[] numbers = numnber.Split(' ');
            int[] arr = new int[numbers.Length];
            for (int i = 0; i <numbers.Length; i++)
            {
                arr[i] =  Convert.ToInt32(numbers[i]);
            }
            Console.Write("Please make sure the newSize number: ");
            int newSize = int.Parse(Console.ReadLine());
            int[] nsize = ResizeArray(arr, newSize);
            Console.Write("The newsize numbers are: ");
            for (int i = 0; i < nsize.Length; i++)
            {
                Console.Write($"{nsize[i]} ");
            }
            Console.WriteLine();
        }

       public static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] nsize = new int[arr.Length+newSize];
            for (int i = 0; i < arr.Length+newSize; i++)
            {
                if(i<arr.Length) nsize[i] = arr[i];
                else if (i >= arr.Length)
                {
                    int j = i % arr.Length;
                    nsize[i] = arr[j];
                }
            }
            return nsize;
        }
    }
}
