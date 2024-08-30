using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public int Width { get; set ; }
        public int Height { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangel : Width = {Width}  , Height = {Height}  , Area = {Width} * {Height} = {Width * Height} ");
        }
    }
}
