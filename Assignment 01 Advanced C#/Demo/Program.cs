using System.Drawing;
using System.Collections;
namespace Demo
{
    internal class Program
    {
        public static int SumArray(ArrayList arraylist)
        { 
        
            int sum = 0;

            for (int i = 0; i < arraylist.Count; i++)
            {
                sum += (int) arraylist[i]; 
            }

            return sum;
        }

        public static int SumList(List<int> List)
        {

            int sum = 0;

            for (int i = 0; i < List.Count; i++)
            {
                sum += List[i];
            }

            return sum;
        }
        static void Main(string[] args)
        {
            #region NonGeneric Swap
            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap(ref A, ref B );
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");


            //double A = 5.3;
            //double B = 4.2;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Point P01 = new Point(5, 10);
            //Point P02 = new Point(20, 15);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Helper.Swap(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            #endregion

            #region Generic Swap

            // in case Generic "T" is Declared on method level 
            // Compiler can detect type of "T" based on method parameter
           


            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap<int>(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //  Console.WriteLine("============================");

            //double A = 5.3;
            //double B = 4.2;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap<double>(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");


            // Console.WriteLine("============================");


            //Point P01 = new Point(5, 10);
            //Point P02 = new Point(20, 15);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Helper.Swap<Point>(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            #endregion

            #region Generic Search
            //Employee employee01 = new Employee() { Id = 10 , Name = "Nasr" , Salary = 15_000 };
            //Employee employee02 = new Employee() { Id = 15, Name = "Mohamed", Salary = 7_000 };
            //Employee employee03 = new Employee() { Id = 16, Name = "karim", Salary = 12_000 };
            //Employee employee04 = new Employee() { Id = 48, Name = "karm", Salary = 17_000 };
            //Employee employee05 = new Employee() { Id = 78, Name = "Ahmed", Salary = 42_000 };

            ////                           0           1          2               3           4
            //Employee[] employees = { employee01  , employee02, employee03 , employee04 , employee05};

            //int index = Helper<Employee>.SearchArray(employees, employee05);

            //Console.WriteLine(index); 
            #endregion

            #region Equality in class and struct
            //Employee employee01 = new Employee() { Id = 10, Name = "Mohamed", Salary = 6_000 };
            //Employee employee02 = new Employee() { Id = 12, Name = "Nasr", Salary = 7_000 };
            //Employee employee03 = new Employee() { Id = 10, Name = "Mohamed", Salary = 6_000 };

            //Console.WriteLine($"empolyee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"empolyee02 = {employee03.GetHashCode()}");

            //// if (employee01 == employee03)
            //if (employee01.Equals(employee03))
            //    Console.WriteLine("EQUAl");
            //else
            //   Console.WriteLine("NOT EQUAL");

            #endregion

            #region Genric sort 
            //Employee[] employees =
            //{
            //    new Employee(10 , "Nasr" , 3_000),
            //    new Employee(20 , "Mohamed" , 4_000),
            //    new Employee(20 , "karim" , 7_000),
            //    new Employee(10 , "aya" , 10_000),
            //    new Employee(10 , "karm" , 40_000),
            //    new Employee(10 , "radwa" , 2_000),
            //};

            //Helper<Employee>.BubbleSort(employees);

            //Console.WriteLine(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region IComparable VS Genric IComparable
            //Point[] points =
            //{
            //    new Point(25,9),
            //    new Point(7,7),
            //    new Point (1,5),
            //    new Point(90,16),
            //    new Point(30,5)
            //};

            //Helper<Point>.BubbleSort(points);

            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //} 
            #endregion



        }
    }
}