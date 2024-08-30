using SolutionOfAssignment.Interfaced01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Hight { get; set; }
        public double Area
        {
            get { return Width * Hight; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Recatangle with hight {Hight} and Width {Width} is = {Area} "); 
        }
    }
}
