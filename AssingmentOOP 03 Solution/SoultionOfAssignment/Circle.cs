using SolutionOfAssignment.Interfaced01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set ; }
        public double Area 
           { 
            get { return Math.PI * Radius * Radius; }
           }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of circle with Radius of {Radius} is = {Area}");
        }
    }
}
