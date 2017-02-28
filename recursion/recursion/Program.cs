
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            
            if (start == stop)
            {
                /* stopping condition - what needs to be done? */
                Console.WriteLine(start);
            }
            else
            {
                /* recursive call and print start*/
                if (start > stop)
                {
                    Console.WriteLine(start);
                    range(start - 1, stop);                    
                }
                else
                {
                    Console.WriteLine(start);
                    range(start + 1, stop);                   
                }
                               
            }
        }

        static string getNumberString(int n)
        {
            if (n == 0)
                return "0";
            else
            {                
                return n.ToString() + getNumberString(n - 1);
            }
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
            {
                return x + multiply(x, dec(y));
            }

        }

        static int power(int x, int y)
        {
            if (y == 1)
                return x;
            else
            {
                return x * power(x, dec(y));
            }
        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }




        static void Main(string[] args)
        {
            //printNumbers(5);
            //range(5, 10);
            //Console.WriteLine(getNumberString(4));
           // Console.WriteLine(multiply(2, 10));
            Console.Write(power(2, 4));
            //Console.WriteLine("{0}", dec(dec(10)));
            //Console.WriteLine("{0}", inc(inc(inc(inc(2)))));
            //Console.WriteLine("{0}", inc(dec(inc(inc(2)))));

            Console.ReadLine();
        }



    }
}
