using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int f1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the last number");
            int f2 = int.Parse(Console.ReadLine());
            int i, sum;
            for(int n= f1; n<= f2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);


            }
            Console.WriteLine();
        }
    }
}
