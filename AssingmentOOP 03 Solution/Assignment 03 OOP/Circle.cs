using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class Circle : ICircle
    {
        public double Area { get ; set ; }
        double ICircle.Raduis { get ; set ; }

        public double Raduis;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle : Raduis = {Raduis} , Area = {Math.PI} * {Raduis} * {Raduis} = {Math.PI * Raduis *Raduis}");
        }
    }
}
