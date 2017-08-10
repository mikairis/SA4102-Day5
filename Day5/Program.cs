using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************This is day 5 quiz**************");

            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
            };

            int count = 0;
            Start:
            Console.WriteLine("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            foreach (int i in theArray)
            {
                if (i == input)
                {
                    count++;
                }
            }
            Console.WriteLine("The number " + input + " appeared " + count + " times!");
            Console.ReadKey();
            goto Start;
        }
    }
}
