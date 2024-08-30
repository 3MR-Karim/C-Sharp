using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04.First_Project
{
    internal class Point3D : IComparable,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point3D p = (Point3D)obj;
            return (X == p.X) && (Y == p.Y) && (Z == p.Z);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(X, Y, Z).GetHashCode();
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null))
            {
                return ReferenceEquals(p2, null);
            }
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Point3D otherPoint = obj as Point3D;
            if (otherPoint != null)
            {
                int result = this.X.CompareTo(otherPoint.X);
                if (result == 0)
                {
                    result = this.Y.CompareTo(otherPoint.Y);
                }
                return result;
            }
            else
            {
                throw new ArgumentException("Object is not a Point3D");
            }
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }

        
    }
}
