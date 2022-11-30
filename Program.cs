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
            Console.WriteLine("***** Q=1 for Ans 1 || Q=2 for Ans 2 || Q=3 for Ans 3 *****");
            Console.WriteLine("Enter Question No:");
            int Q = Convert.ToInt32(Console.ReadLine());                    
            if (Q==1) {
                int Space, n;
                Console.WriteLine("\n \nEnter Number:");
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
            else if(Q==2)
            {
                Console.Write("\n \nInput: This is dotnet Interview \n");
                string originalString = "This is dotnet Interview";
                StringBuilder reverseWordString = new StringBuilder();
                List<char> charlist = new List<char>();
                for (int i = 0; i < originalString.Length; i++)
                {
                    if (originalString[i] == ' ' || i == originalString.Length - 1)
                    {
                        if (i == originalString.Length - 1)
                            charlist.Add(originalString[i]);
                        for (int j = charlist.Count - 1; j >= 0; j--)
                            reverseWordString.Append(charlist[j]);
                        reverseWordString.Append(' ');
                        charlist = new List<char>();
                    }
                    else
                    {
                        charlist.Add(originalString[i]);
                    }
                }
                Console.WriteLine($"Output : {reverseWordString.ToString()}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Q3 yet to come ");
                Console.ReadKey();
            }
        }
    }
}
