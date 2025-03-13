using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////
            //int n;
            //Console.Write("Enter Your Number ");
            //n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("Even Number ");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number ");
            //}

            /////////////////////////////////
            //int k;
            //Console.Write("Enter Year");
            //k= int.Parse(Console.ReadLine());
            //if (k % 400 == 0 || k % 4 == 0)
            //{
            //    Console.WriteLine("Leap Yaer");
            //}
            //else
            //{
            //    Console.WriteLine("Not A leap Yaer");
            //}

            /////////////////////////////////////

            int n;
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(i);
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }









        }
    }
}
