using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Iam A Parent [Base]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X : {X}");
        }

        public Parent (int X)
        {
            this.X = X;
        }
    }
}
