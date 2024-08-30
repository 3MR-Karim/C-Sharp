using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04.Second_Project
{
    
    internal class Maths
    {
       public static void Add  (double? X , double? Y)
        {
            if (X == null || Y == null)
            {
                Console.WriteLine("Please Enter A valid number");
                return;
            }
            else
            {
                Console.WriteLine($"{X} + {Y} = {X + Y}");
            }
        }

        public static void Sub(double? X, double? Y)
        {
            if (X == null || Y == null)
            {
                Console.WriteLine("Please Enter A valid number");
                return;
            }
            else
            {
                Console.WriteLine($"{X} - {Y} = {X - Y}");
            }
        }
        public static void Mul(double? X, double? Y)
        {
            if (X == null || Y == null)
            {
                Console.WriteLine("Please Enter A valid number");
                return;
                
            }
            else
            {
                Console.WriteLine($"{X} * {Y} = {X * Y}");
            }
        }
        public static void Divide(double? X, double? Y)
        {
            if (X == null || Y == null)
            {
                Console.WriteLine("Please Enter A valid number");
                return;
            }
            if(Y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            else
            {
                Console.WriteLine($"{X} / {Y} = {X / Y}");
            }
        }
    }
}
