using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int F1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter last number");
            int F2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers:");
            int sum = 0;
            for(int a = F1; a <= F2; a++)
            {
                for (int b = 1; b <= a; b++) 
                {
                    if (a % b == 0)
                        sum++;
                    
                }
                if (sum == 2)
                {
                    Console.WriteLine(a);
                    
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }
        }
    }
}
