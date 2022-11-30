using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrivePass
{
    class Program
    {
        static void Main(string[] args)
        {

            int Space, n;
            Console.WriteLine("Enter Number:");
            int noflayer = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= noflayer; i++)
            {
                for (Space = 1; Space <= (noflayer - i); Space++)
                    Console.Write(" ");
                for (n = 1; n <= i; n++)
                    Console.Write(n);
                for (n = (i - 1); n >= 1; n--)
                    Console.Write(n);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
