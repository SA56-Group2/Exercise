using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Quiz_0214_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string upperPlainText = ReturnUpperInputSentence(); 
            string encryptedText = EncryptSentence(upperPlainText);
            PrintEncryptedSentence(encryptedText);
            string decryptedText = DecrpytSentence(encryptedText); 
            PrintDecryptedSentence(decryptedText);
            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }

        static string ReturnUpperInputSentence()
        {
            Console.Write("Please enter the sentence: ");
            string str = Console.ReadLine();
            string numberUpper = str.ToUpper();
            return numberUpper;
        }

        static string EncryptSentence(string upperPlainText)
        {
            string letterlist = "ABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            string newUp = null;
            string med = upperPlainText;
            for (int i = 0; i < upperPlainText.Length; i++)
            {
                
                for (int j = 0; j < letterlist.Length; j++)
                {
                    string a = med.Substring(i, 1);
                    string b = letterlist.Substring(j, 1);
                    string c = letterlist.Substring(j+3, 1);
                    if (a == b)
                    {
                        newUp = med.Replace(a,c);
                        med = newUp;
                        break;
                    }
                }
            }
            return med;
        }

        static void PrintEncryptedSentence(string encryptedText)
        {
            Console.WriteLine("The encrypted sentence is :{0}",encryptedText);
        }

        static string DecrpytSentence(string encryptedText)
        {
            string letterlist = "CBAZYXWVUTSRQPONMLKJIHGFEDCBA";
            string newUp = null;
            string med = encryptedText;
            for (int i = 0; i < encryptedText.Length; i++)
            {
                for (int j = 0; j < letterlist.Length; j++)
                {
                    string a = med.Substring(i, 1);
                    string b = letterlist.Substring(j, 1);
                    string c = letterlist.Substring(j+3, 1);
                    if (a == b)
                    {
                        newUp = med.Replace(a,c);
                        med = newUp;
                        break;
                    }
                }
            }
            return med;
        }

        static void PrintDecryptedSentence(string decryptedText)
        {
            Console.WriteLine("The decrpyted sentence is :{0}",decryptedText);

        }
    }
}
