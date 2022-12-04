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
            int firstNumber = 0;
            int SecondNumber = 1;
            int nextNumber;
            int numberOfElements;

            Console.WriteLine("Enter the number of element : ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.WriteLine("Enter the number greater than two : ");
            }
            else
            {
                Console.WriteLine(firstNumber + " " + SecondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
                Console.ReadLine();

            }
        }
    }

}
        
    
