using Assignment_04.First_Project;
using Assignment_04.Second_Project;
using Assignment_04.Third_Project;

namespace Assignment_04
{
    internal class Program
    {
        private static Point3D ReadPointFromConsole()
        {
            int x, y, z;
            if (int.TryParse(Console.ReadLine(), out x) &&
                int.TryParse(Console.ReadLine(), out y) &&
                int.TryParse(Console.ReadLine(), out z))
            {
                return new Point3D(x, y, z);
            }
            else
            {
                throw new FormatException("Invalid input. Please enter integer values.");
            }
        }
        static void Main(string[] args)
        {

        #region First Project
            //try
            //{
            //    Console.WriteLine("Enter coordinates for point P1 (x, y, z):");
            //    Point3D p1 = ReadPointFromConsole();

            //    Console.WriteLine("Enter coordinates for point P2 (x, y, z):");
            //    Point3D p2 = ReadPointFromConsole();

            //    Console.WriteLine($"P1: {p1}");
            //    Console.WriteLine($"P2: {p2}");

            //    if (p1 == p2)
            //    {
            //        Console.WriteLine("P1 and P2 are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("P1 and P2 are not equal.");
            //    }

            //    Point3D[] pointsArray = new Point3D[] {
            //    new Point3D(3, 2, 5),
            //    new Point3D(1, 5, 7),
            //    new Point3D(2, 2, 2)
            //};

            //    Array.Sort(pointsArray);

            //    Console.WriteLine("Sorted points based on X and Y coordinates:");
            //    foreach (var point in pointsArray)
            //    {
            //        Console.WriteLine(point);
            //    }

            //    Point3D clonePoint = (Point3D)p1.Clone();
            //    Console.WriteLine($"Cloned point: {clonePoint}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        
        #endregion

        #region Second Project
        //Maths.Divide(10, 1);
        //Maths.Mul(10, 4);
        //Maths.Sub(10, 5);
        //Maths.Add(5, 4);
        #endregion

        #region Third Project
        //Duration D1 = new Duration(0, 0, 0);
        //Console.WriteLine(D1.ToString());

        //Duration D2 = new Duration(2, 10, 15);
        //Console.WriteLine(D2.ToString());
        // Duration D3;

        //D3 = D1 + D2;
        //Console.WriteLine(D3.ToString());

        //D3 = D1 + 7800;
        //Console.WriteLine(D3.ToString());

        //D3 = 666 + D3;
        //Console.WriteLine(D3.ToString());

        //D3 = ++D1; //(Increase One Minute)
        //Console.WriteLine(D3.ToString());


        //D3 = --D2; //(Decrease One Minute)
        //Console.WriteLine(D3.ToString());


        //D1 = D1 - D2;
        //Console.WriteLine(D1.ToString());

        //if(D1 > D2)
        //{
        //    Console.WriteLine("Hi");
        //}
        //if(D1 <= D2)
        //{
        //    Console.WriteLine("Bye");
        //}


        //if (D1) // true
        //{
        //    Console.WriteLine("HI");
        //}
        //else // false
        //{
        //    Console.WriteLine("Bye");
        //}


        //DateTime Obj = (DateTime)D1;


        #endregion

        }

        
    }
}
