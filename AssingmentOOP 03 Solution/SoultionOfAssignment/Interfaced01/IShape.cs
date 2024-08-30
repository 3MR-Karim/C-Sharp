using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment.Interfaced01
{
    internal interface IShape
    {
        public double Area { get; }

        public void DisplayShapeInfo();
    }
}
