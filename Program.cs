using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCD
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //C1
            /*Console.WriteLine("What's your gender? Type F or M please!");
            string gender1 = (Console.ReadLine()).ToUpper();
            string prefix1 = null;
            switch(gender1)
            {
                case "M":
                    prefix1 = "Mr.";
                    break;
                case "F":
                    prefix1 = "Ms.";
                    break;
            };
            Console.WriteLine("What's your name?");
            string name1= (Console.ReadLine());
            Console.WriteLine($"Good morning {prefix1}{name1}.");

            //C2
            Console.WriteLine("What's your gender? Type F or M please!");
            string gender2 = (Console.ReadLine()).ToUpper();
            Console.WriteLine("What's your age?");
            int age2=Convert.ToInt32(Console.ReadLine());
            string prefix2 = null;
            switch (gender2)
            {
                case "M":
                    if (age2 > 45) { prefix2 = "uncle"; } else { prefix2 = "Mr."; }
                    break;
                case "F":
                    if (age2 > 45) { prefix2 = "aunty"; } else { prefix2 = "Ms."; }
                    break;
            };
            Console.WriteLine("What's your name?");
            string name2 = (Console.ReadLine());
            Console.WriteLine($"Good morning {prefix2}{name2}.");

            //C3
            Console.WriteLine("What's your score?");
            int score=Convert.ToInt32(Console.ReadLine());
            string grade = score >= 80 && score <= 100 ? "A" :
                score >= 60 && score < 80 ? "B" :
                score >= 40 && score < 60 ? "C" :"Error";
            Console.WriteLine($"You scored {score}, which is grade {grade}.");

            //C4
            Console.WriteLine("What's the input?");
            double km = Math.Ceiling(Convert.ToDouble(Console.ReadLine())*10)/10;
            Console.WriteLine(km);
            double charge = 0;
            if (km <= 0.5)
            {
                charge = 2.4;
            }else if (km > 0.5 && km <= 8.5)
            {
                charge = 2.4 + (km-0.5) * 0.4;
            }else if (km > 8.5)
            {
                charge = 2.4 + 8.5 * 0.4 + (km - 9) * 0.5;
            }
            Console.WriteLine(charge);

            //c5
            Console.WriteLine("What's the input?");
            double input5=Convert.ToDouble(Console.ReadLine());
            double hundredDigit = Math.Floor(input5 / 100);
            double tenthDigit = Math.Floor((input5-hundredDigit*100) / 10);
            double digit = input5 - hundredDigit * 100 - tenthDigit * 10;
            bool output = (input5 == hundredDigit * hundredDigit*hundredDigit + tenthDigit * tenthDigit*tenthDigit + digit * digit*digit)?true:false;
            Console.WriteLine(output);
            Console.ReadKey();

            //D1
            string numberInput = null;
            do
            {
                Console.WriteLine("What's your input?");
                numberInput = Console.ReadLine();
            } while (numberInput != "88");
            Console.WriteLine("Lucky you have input the correct number!");

            //D2
            Console.WriteLine("What's the number of A?");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the number of B?");
            int B = Convert.ToInt32(Console.ReadLine());
            while (A != B)
            {
                if (A < B) { B = B - A; } else if (A > B) { A = B - A; }
            }
            int HCF = A;
            Console.WriteLine("HCF has been found, which is {0}",HCF);
            int LCM = (A * B) / HCF;
            Console.WriteLine("{0} is the LCM.", LCM);

            //D3-a
            Random rnd = new Random();
            int generatedNumber = rnd.Next(0, 10);
            Console.WriteLine(generatedNumber);
            int guess = 0;
            do
            {
                Console.WriteLine("Guess an integer number please: ");
                guess = Convert.ToInt32(Console.ReadLine());
            } while (guess != generatedNumber);
            Console.WriteLine("Yeah! YOU GOT IT!");*/

            //D3-b

            Random rnd1 = new Random();
            int generatedNumber1 = rnd1.Next(0, 10);
            Console.WriteLine("The computer generated number is {0}", generatedNumber1);
            int count = 0;
            int guess1 =0;
            do
            {
                Console.WriteLine("Guess an integer between 0 and 9 please: ");
                guess1 = Convert.ToInt32(Console.ReadLine());
                count++;
            } while (guess1 != generatedNumber1);
            
            if (count <= 2) 
            {
                Console.WriteLine("You are a good guess!");
            }else if(count>2&&count<=5) 
            {
                Console.WriteLine("You are a wizard");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }

        }
    }
}
