using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point :  IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x , int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

       //public int CompareTo(object? obj)
       // {
       //   // Point passedpoint =( Point) obj; // unsafe casting


       //     // is conditioal opertor
       //     // will return true 3 :
       //     // 1. obj is null
       //     //2. obj is point
       //     // 3 obj is object inhrirt from point

       //    // as casting opertor

       //     Point passedPoint = obj as Point;

       //     if (passedPoint != null)
       //     {
       //         return 1;
       //     }
       //     if(this.x == passedPoint.x)
       //         return this.y.CompareTo(passedPoint.y);
       //     else
       //         return this.x.CompareTo(passedPoint.x);
       // }

        public int CompareTo(Point? passedPoint)
        {
            if (passedPoint is null)
            {
                return 1;
            }
            if (this.X == passedPoint.X)
                return this.Y.CompareTo(passedPoint.Y);
            else
                return this.X.CompareTo(passedPoint.X);
        }
    }
}

