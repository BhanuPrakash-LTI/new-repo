﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.WriteLine("Enter the first number");
                 a = Convert.ToInt32(Console.ReadLine());

            } while (a == 0);

            do
            {
                Console.WriteLine("Enter the second number");
                 b = Convert.ToInt32(Console.ReadLine());
            }
            while (b == 0);

             int sum = a + b;
            long product = a * b;
            int diff = a - b;
            int div = a / b;

            Console.WriteLine("The Sum is " + sum);
            Console.WriteLine("The product is " + product);
            Console.WriteLine("The Difference is " + diff);
            Console.WriteLine("The division is " + div);

            Console.ReadKey();
        }
    }
}
