using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEandF
{
    internal class F5
    {
        static void Main()
        {
            string[] nameArray = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] markArray = new int[] { 63, 29, 75, 82, 55 };
            List<String> nameList= new List<String>();
            List<int> markList = new List<int>();  
           
            foreach(string n in nameArray)
            {
                nameList.Add(n);
            }
            foreach(int m in markArray)
            {
                markList.Add(m);
            }

            nameList.Sort();
            markList.Sort((a,b)=>b.CompareTo(a));
            Console.WriteLine("Sorted Mark: ");
            foreach (int m in markList)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("Sorted Name: ");
            foreach (string n in nameList)
            {
                Console.WriteLine(n);
            }

        }


    }
}
