using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child:Parent 
    {
        public  int Y { get; set; }

        // Method Override
        public void Fun01()
        {
            Console.WriteLine("Iam A Child [Sub]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X : {X}   Y : {Y}");
        }

        // External Constructor Chaining
        public Child(int X , int Y) : base(X)
        {
            this.Y = Y;
        }
    }
}
