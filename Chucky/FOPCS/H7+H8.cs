using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using CONNECTDATA = System.Runtime.InteropServices.ComTypes.CONNECTDATA;

namespace CompleteCsharpmasterclass
{
    class Program
    {
        delegate double DoubleOps(double x);
        
        public static void Main(string[] args)
        {
            //H8
            double[] arr = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7 };
            DoubleOps doubleOps = Sqrt;
            DoubleOps doubleSquare = Sqare;
            double[] newArr = ProcessArray(arr, doubleOps);
            double[] newArr1 = ProcessArray(arr, doubleSquare);
            
            foreach (var num in newArr)
            {
                Console.Write($"{num:f2}"+"\t");
            }
            
            Console.WriteLine();
            
            foreach (var num in newArr1)
            {
                Console.Write($"{num:f2}"+"\t");
            }

            // H7
            int[,] a = { {1,2,3}, {3,4,5} };
            Console.WriteLine(a.Rank);
            int[,] aMatrix = {{1,2,3},{1,2,3},{1,2,3},{1,2,3}};
            int[,] bMatrix = {{3,4},{3,4},{3,4}};
            int[,] cMatrix = MatrixMultiply(aMatrix, bMatrix);
            
            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bMatrix.Length/(bMatrix.Rank+1); j++)
                {
                    Console.Write(cMatrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            
        }

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] numArray = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numArray[i] = ops(arr[i]);
            }
            return numArray;
        }

        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double Sqare(double x)
        {
            return x * x;
        }

        public static int[,] MatrixMultiply(int[,] aMatrix, int[,] bMatrix)
        {
            int[,] multiM = new int[aMatrix.GetLength(0),bMatrix.GetLength(1)];
            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < bMatrix.GetLength(0); k++)
                    {
                        multiM[i, j] += aMatrix[i, k] * bMatrix[k, j];
                    }
                }
            }
            return multiM;
        } 
        
    }
}



    
