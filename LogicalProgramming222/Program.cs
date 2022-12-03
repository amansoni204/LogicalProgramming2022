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
             Console.WriteLine("Enter the number check perfect or not : ");
            int num =Convert.ToInt32(Console.ReadLine());   
            int temp = 0;
            for (int i = 1; i < num; i++)
            {
                if (num%i==0)
                {
                    temp=temp+i;
                }
            }
            if (temp == num)
            {
                Console.WriteLine($"{num} is a perfect number");

            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }
            Console.ReadLine();  Console.WriteLine("Enter the number check perfect or not : ");
           
        }
    }
}
