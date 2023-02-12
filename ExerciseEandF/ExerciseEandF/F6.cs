using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F6
    {
       static private string mNumber,checkSum, calculatedCheckSum;
       static private bool isValidFormat, isValidCheckSum;
        static private int multiplier=6;
        static private int remainder;
        static private int sum=0;
        static private string upperValue;
        static private int[] mark = new int[5];
        static private int[] multiplyResult = new int[5];

        static void Main()
        {

            Console.WriteLine("Enter a matriculation number: ");
            mNumber = Console.ReadLine();
            validateInput(mNumber);
            if(isValidFormat)
            {
 //changing the value of input to all uppercase and extract the last index to variable
                upperValue = mNumber.ToUpper();
                checkSum = upperValue.Substring(6);

//calculating the multiple, sum and store in the variable to calculate remainder

                for(int i = 0; i < mark.Length; i++)
                {
                    mark[i] = int.Parse(upperValue[i+1].ToString());
                    multiplyResult[i] = mark[i] * multiplier;
                    sum += multiplyResult[i];
                    multiplier--;
                }

                remainder = sum % 5;

                validateCheckSum(remainder);
                if (isValidCheckSum)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

        }
       static void validateInput(string input)
        {

            if (input.Length == 7)
            {
                    if (char.IsLetter(input[0]) && char.IsLetter(input[6]))
                    {
                    for (int j = 1; j <= input.Length - 2; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            isValidFormat = true;
                            break;
                        }
                        else
                        {
                            isValidFormat = false;
                            Console.WriteLine("Please Enter 5 middle number");
                            break;
                        }
                    }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter First and Last 2 Alphabet");
                        isValidFormat = false;
                        
                    };
             }
            else
            {
                Console.WriteLine("Data should be first and last 2 alphabet and 5 digit");
                isValidFormat = false;
            }
        }

       static void validateCheckSum(int result)
        {
            switch(result)
            {
                case 0:
                    calculatedCheckSum = "O";
                    break;
                case 1:
                    calculatedCheckSum = "P";
                    break;
                case 2:
                    calculatedCheckSum = "Q";
                    break;
                case 3:
                    calculatedCheckSum = "R";
                    break;
                case 4:
                    calculatedCheckSum = "S";
                    break;
            }

            if(checkSum == calculatedCheckSum)
            {
                isValidCheckSum = true;
            }
            else
            {
                isValidCheckSum = false;
            }
        }  
}
    
}
