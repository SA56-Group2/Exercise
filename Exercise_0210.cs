using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;

namespace Exercise_0210
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("1 for E1-1 \t 2 for E2 \t 3 for E3 \t 4 for E4 \t 5 for E5 \t 6 for E6");
            Console.WriteLine("7 for F1 \t 8 for F2 \t 9 for F3 \t 10 for F4 \t 11 for F5 \t 12 for F6");
            Console.WriteLine("0 for Exit.");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                {
                   E1Aexercise();
                   Main();
                   break;
                }
                case 2:
                {
                    E2exercise();
                    Main();
                    break;
                }
                case 3:
                {
                    E3exercise();
                    Main();
                    break;
                }
                case 4:
                {
                    E4exercise();
                    Main();
                    break;
                }
                case 5:
                {
                    E5exercise();
                    Main();
                    break;
                }
                case 6:
                {
                    E6exercise();
                    Main();
                    break;
                }
                case 7:
                {
                    F1exercise();
                    Main();
                    break;
                }
                case 8:
                {
                    F2exercise();
                    Main();
                    break;
                }
                case 9:
                {
                    F3exercise();
                    Main();
                    break;
                }
                case 10:
                {
                    F4exercise();
                    Main();
                    break;
                }
                case 11:
                {
                    F5exercise();
                    Main();
                    break;
                }
                case 12:
                {
                    F6exercise();
                    Main();
                    break;
                }
                case 0:
                    break;
            }
        }

        public static void E1Aexercise()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number+1; i++)
            {
                if (number % i == 0)
                    Console.Write(i+" ");
            }
            Console.ReadLine();
        }

        public static void E2exercise()
        {
            string[] title = new string[]{"NO","INVERSE","SQUARE","ROOT"};
            string[] symbol = new string[] { "-------", "-------", "-------", "-------" };
            double[,] number = new double[12,4];
            for (int i = 0; i < 4; i++)
                Console.Write("{0}\t",title[i]);
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.Write("{0}\t",symbol[i]);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    number[i, 0] = i+1;
                    number[i, 1] = 1/((Convert.ToDouble(i)+1));
                    number[i, 2] = (i+1) * (i+1);
                    number[i, 3] = System.Math.Sqrt(i+1);
                    Console.Write("{0:f3}\t",number[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void E3exercise()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < number; i++)
                if (number % i == 0) count++;
            if(count==0) Console.Write("This number is a prime number");
            else Console.Write("This number is not a prime number");
            Console.ReadLine();
        }

        public static void E4exercise()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum += i;
            }
            if (number == sum) Console.WriteLine("This is a perfect number.");
            else Console.WriteLine("This is not a perfect number.The sum of its factors is {0}",sum);
        }

        public static void E5exercise()
        {
            Console.Write("Please enter the beginning number: ");
            int beginningNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the ending number: ");
            int endingNumber = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers are: ");
            for (int i = beginningNumber; i < endingNumber + 1; i++)
            {
                bool param = isPrime(i);
                if (param == true) Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public static void E6exercise()
        {
            Console.Write("Please enter the beginning number: ");
            int beginningNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the ending number: ");
            int endingNumber = int.Parse(Console.ReadLine());
            Console.Write("The perfect numbers are: ");
            for (int i = beginningNumber; i < endingNumber + 1; i++)
            {
                bool param = isPerfect(i);
                if (param == true) Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public static bool isPrime(int Rannum)
        {
            int count = 0;
            for (int i = 2; i < Rannum; i++)
                if (Rannum % i == 0) count++;
            if(count==0) return true;
            else return false;
        }

        public static bool isPerfect(int Rannum)
        {
            int sum=0;
            for (int i = 1; i < Rannum; i++)
                if (Rannum % i == 0) sum += i;
            if (Rannum == sum) return true;
            else return false;
        }

        public static void F1exercise()
        {
            Console.Write("Please enter the word: ");
            string words = Console.ReadLine();
            string[] vowels = { "a", "e", "i", "o", "u" };
            int[] count = { 0, 0, 0, 0, 0 };
            foreach (var letter in words)
                for (int i = 0; i < vowels.Length; i++)
                    if (vowels[i] == Convert.ToString(letter)) count[i]++;
            for (int i = 0; i < vowels.Length; i++)
                Console.WriteLine("The {0} appears {1} times",vowels[i],count[i]);
        }

        public static void F2exercise()
        {
            Console.Write("Please enter the word: ");
            string word = Console.ReadLine();
            var palindrome = word.ToCharArray();
            Array.Reverse(palindrome);
            int count = 0;
            for (int i = 0; i < word.Length; i++)
                if (word[i] == palindrome[i]) count++;
            if (count == word.Length) Console.WriteLine("It is a palindrome.");
            else Console.WriteLine("It is not a palindrome.");
        }

        public static void F3exercise()
        {
            Console.Write("Please enter the expressions: ");
            string expressions = Console.ReadLine();
            string expressionsLower = expressions.ToLower();
            string[] expressionWord = expressionsLower.Split(' ','.');
            var expesssionCon = string.Concat(expressionWord);

            var palindrome = expesssionCon.ToCharArray();
            Array.Reverse(palindrome);
            int count = 0;
            for (int i = 0; i < expesssionCon.Length; i++)
                if (expesssionCon[i] == palindrome[i]) count++;
            if (count == expesssionCon.Length) Console.WriteLine("It is a palindrome expressions.");
            else Console.WriteLine("It is not a palindrome expressions.");
        }

        public static void F4exercise()
        {
            Console.Write("Please enter the expressions: ");
            string expressions = Console.ReadLine();
            string[] expressionWord = expressions.Split(' ','.');
            string newwordSqu = null;
            foreach (var word in expressionWord)
            {
                string newword = word.Substring(0, 1).ToUpper() + word.Substring(1);
                newwordSqu += newword + " ";
            }
            Console.WriteLine(newwordSqu);
        }

        public static void F5exercise()
        {
            string[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = { 63, 29, 75, 82, 55 };
            Console.WriteLine("--> This is the original display.\n Name\tMark");
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine("{0}\t{1}",name[i],mark[i]);

            Console.WriteLine("-->Sort by mark \n Name\tMark");
            int med = 0;
            string med1 = null;
            for (int i = 0; i < mark.Length-2; i++)
            {
                for (int j = 0; j < mark.Length-1; j++)
                {
                    if (mark[j] < mark[j + 1])
                    {
                        med = mark[j];
                        mark[j] = mark[j + 1];
                        mark[j + 1] = med;
                        med1 = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = med1;
                    }
                }
            }
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine("{0}\t{1}",name[i],mark[i]);
            
            Console.WriteLine("-->Sort by name \n Name\tMark");
            int med3 = 0;
            string med2 = null;
            
            for (int i = 0; i < mark.Length-2; i++)
            {
                for (int j = 0; j < mark.Length-1; j++)
                {
                    byte[] a1 = System.Text.Encoding.ASCII.GetBytes(name[j]);
                    byte[] a2 = System.Text.Encoding.ASCII.GetBytes(name[j+1]);
                    if (a1[0] > a2[0])
                    {
                        med3 = mark[j];
                        mark[j] = mark[j + 1];
                        mark[j + 1] = med3;
                        med2 = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = med2;
                    }

                    if ((a1[0] == a2[0])&&(a1[1] > a2[1]))
                    {
                        med3 = mark[j];
                        mark[j] = mark[j + 1];
                        mark[j + 1] = med3;
                        med2 = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = med2;
                    }
                }
            }
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine("{0}\t{1}",name[i],mark[i]);


        }

        public static void F6exercise()
        {
            Console.Write("Please enter the matriculation number: ");
            string matriNunmber0 = Console.ReadLine();
            string matriNunmber = matriNunmber0.ToUpper();
            if (matriNunmber.Length != 7)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                string number = matriNunmber.Substring(1, 5);
                char lastLet = char.Parse(matriNunmber.Substring(6,1));
                string[] checksum = { "O", "P", "Q", "R", "S" };
                int[] multi = {6, 5, 4, 3, 2};
                int sum = 0;
                for (int i = 0; i < number.Length; i++)
                    sum += number[i] * multi[i];
                char lastCheck = char.Parse(checksum[sum % 5]);
                if (lastCheck == lastLet) Console.WriteLine("Valid");
                else Console.WriteLine("Invalid");
            }
        }
    }
    
}