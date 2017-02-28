
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            int c = 0;
            float sum = 0;
            float average = 0;
            string input;
            Console.WriteLine("How many numbers ?:");
            input = Console.ReadLine();  //waits for user to hit return
            num1 = Convert.ToInt32(input);
            while (c < num1)
            {
                Console.WriteLine("enter a number:");
                input = Console.ReadLine();  //waits for user to hit return
                num2 = Convert.ToInt32(input);
                sum = sum + num2;
                c++;
            }
            average = sum / num1;
            Console.WriteLine("average is : {0}", average);


            /* Console.WriteLine("Enter 2nd Number :");
             input = Console.ReadLine();
             num2 = Convert.ToInt32(input);
             Console.WriteLine("Power is : {0}", power(num1, num2));
             //{0} takes 1st argument and substitutes into string
             */
            Console.ReadKey();  //waits for a key to press before ending
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int power(int x, int y)
        {
            int z = x;
            for (int i = 1; i < y; i++)
            {
                z = z * x;
            }
            return z;
        }

    }
}