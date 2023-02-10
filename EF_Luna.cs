using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //E1
            Console.WriteLine("Please enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int initial = 1;
            // incremental
            for (int i = 1; i <= number; i++)
            {
                initial *= i;
            }
            //decremental
            for (int i = number;i>0;i--)
            {
                initial*= i;
            }
            Console.WriteLine(initial);

            //E2
            for (double i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
                Console.WriteLine(1 / i);
                Console.WriteLine(i * i);
                Console.WriteLine(Math.Sqrt(i));
            }

            //E3
            Console.WriteLine("The number you want to check: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            int checker=0;
            for(int i=2; i<numberInput; i++)
            {
                if (numberInput % i == 0)
                {
                    Console.WriteLine("This is a prime number!");
                    checker++;
                    break;
                }
            }
            if(checker==0)
            {
                Console.WriteLine("This is not a prime number.");
            }

            //E4
            Console.WriteLine("The number you want to check: ");
            int number4=Convert.ToInt32(Console.ReadLine());
            List<int> termsList= new List<int>();
            int result = 1;
            for(int i=1; i<=number4; i++)
            {
                if(number4%i==0)
                {
                    termsList.Add(i);
                }
            }
            foreach(int i in termsList)
            {
                result+=i;
            }
            if(result == number4) 
            {
                Console.WriteLine("Perfect Number!");
            }
            else
            {
                Console.WriteLine("Not a perfect number.");
            }

            //E5
            bool isPrimeNumber;
            
            for (int i = 5; i <= 10000; i++) 
            {
                isPrimeNumber=true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber=false;
                        break;
                    }
                }
                if (isPrimeNumber==true)
                {
                    Console.WriteLine(i);
                }
            }

            //E6
            int sum = 0;
            for (int i=1; i<=10;i++)
            {
                sum = 0;
                for(int j=1;j<i;j++)
                {
                    if(i%j==0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }

            //F1&F2
            char[] vowelArray = {'a','e','i','o','u'};
            Console.WriteLine("Please type in a phrase.");
            string phrase=Console.ReadLine();
            int count = 0;
            foreach(char vowel in vowelArray)
            {
                count = 0;
                foreach(char a in phrase)
                {
                    if(a == vowel) count++;
                }
                Console.WriteLine("{0} has {1} totally in this phrase.",vowel,count);
            }

            //F2
            Console.WriteLine("Give me an input: ");
            string givenString=Console.ReadLine();
            int stringLength=givenString.Length;
            char[] ch=new char[stringLength];
            int checker = 0;
            for (int i = 0, j = ch.Length - 1; i < ch.Length; i++, j--)
            {
                if (givenString[i] != givenString[j])
                {
                    Console.WriteLine("Not a palindrome.");
                    break;
                }
                checker++;
            }
            if (checker == stringLength)
            {
                Console.WriteLine("palindrome");
            }
            //F3
            Console.WriteLine("Give me an input: ");
            string givenString2 = (Console.ReadLine()).Replace(" ",",");
            StringBuilder sb = new StringBuilder();
            foreach (char c in givenString2)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            givenString2=sb.ToString().ToLower();
            string newString = "";
            int index = 0;
            for(int i=givenString2.Length-1;i>=0;i--)
            {
                newString+=givenString2[i];
            }
            if(givenString2.Equals(newString))
            {
                Console.WriteLine("palindrome");
            }

            //F4
            Console.WriteLine("Give me a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string newSentence = "";
            foreach(string word in words)
            {
                string a = Convert.ToString(word[0]);
                a=a.ToUpper();
                newSentence+=(a+word.Substring(1)+" ");
            }
            Console.WriteLine(newSentence);

            //F5
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] scores = new int[] { 63, 29, 75, 82, 55 };
            int bottle;
            string bottle_name;
            for(int i=0;i<5;i++)
            {
                for(int j = i+1; j < 5; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        bottle = scores[i];
                        scores[i] = scores[j];
                        scores[j] = bottle;

                        bottle_name = names[i];
                        names[i] = names[j];
                        names[j] = bottle_name;
                    }
                }
            }
            //these two lines just for testing
            foreach(int score in scores) {
                Console.WriteLine(score);
            }
            foreach (string name in names) {
                Console.WriteLine(name);
            }
            //F5-2
            List<string> nameList = new List<string>() { "John", "Venkat", "Mary", "Victor", "Betty" };
            nameList.Sort();
            //this foreach loop just for testing...
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }

            //F6
            Console.WriteLine("Enter a matriculation number: ");
            string ID=Console.ReadLine();
            int[] numbers = new int[5];
            string final= "p";
            string checkSum=null;
            for(int i=1;i<7;i++)
            {
                if(i==6)
                {
                    final = Convert.ToString(ID[i]); 
                    break;
                }
                numbers[i-1] = Convert.ToInt32(ID[i]);
            }
            int remainder = (numbers[0] * 6 + numbers[1] * 5 + numbers[2] * 4 + numbers[3] * 3 + numbers[4]*2)%5;
            
            switch(remainder)
            {
                case 0:
                    checkSum = "O";
                    break;
                case 1:
                    checkSum = "P";
                    break;
                case 2:
                    checkSum = "Q";
                    break;
                case 3:
                    checkSum = "R";
                    break;
                case 4:
                    checkSum = "S";
                    break;
            }
            
            if (checkSum.Equals(final))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}
