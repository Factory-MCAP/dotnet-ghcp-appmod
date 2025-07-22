using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCopilot
{
  public class Program
    {

        static void Main(string[] args)
        {
            // Print out Hello, Copilot 3,000 time with incrementing index
            for (int i = 0; i < 3000; i++)
            {
                Console.WriteLine($"Hello, Copilot {i}");
            }

            // Sum all the numbers in a list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum of numbers: {Sum(numbers)}");
            
        }


        

        /* Function to sum all the numbers in a list of integers */
        private static int Sum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
            

        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public static int SubtractTwoNumbers(int v1, int v2)
        {
            //return v1-v2;
            return v1 - v2;

        }

        //function to divide two numbers
        public static int DivideTwoNumbers(int v1, int v2)
        {
          
            return v1 / v2;
        }



    }
}
