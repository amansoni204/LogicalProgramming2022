using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to get it reversed.");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0;
            Console.WriteLine($"Original number is {num}");
            while (num != 0)
            {
                int rem = num % 10;
                revNum = (revNum * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine($"Reverse number is {revNum}");
            Console.ReadLine();

        }
        }

    }


        
    
