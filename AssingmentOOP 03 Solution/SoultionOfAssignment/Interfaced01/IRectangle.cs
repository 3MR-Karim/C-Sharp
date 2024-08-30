using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment.Interfaced01
{
    internal interface IRectangle : IShape
    {
        public int Width { get; set; }
        public int Hight { get; set; }
    }
}
