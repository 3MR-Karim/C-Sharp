using Assingment_03.Built_in_Interface;
using Assingment_03.InterfaceEx01;
using Assingment_03.InterfaceEx02;
using Assingment_03.InterfaceEx03;

namespace Assingment_03
{
    internal class Program
    {
        static void Print10Numbers(ISeries Series)
        {
            if (Series is not null){

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Series.Current + " ");
                    Series.GetNext();

                }
                Console.WriteLine();
                Series.Reset();
            }
        }

        //class Empolyee : IComparable
        //{
        //    public int Id;
        //    public string Name;
        //    public double Salary;

        //    public int CompareTo(object? obj)
        //    {
        //        Empolyee passed = (Empolyee) obj;

        //        if (this.Salary > passed.Salary)  return 1; 
        //        else if (this.Salary < passed.Salary) return -1; 
        //        else return 0; 
        //    }

        //    public override string ToString()
        //    {
        //        return $"ID : {Id} , Name : {Name} , Salary : {Salary} ";
        //    }
        //}

        static void Main(string[] args)
        {
            #region Ex01
            ////MyType mytype = new MyType();
            ////mytype.Myfun();

            //IMytype imtype;
            //imtype = new MyType();

            //imtype.print(); 
            #endregion

            #region Ex02
            ////SeriesByTwo MySeries = new SeriesByTwo();
            ////Print10Numbers(MySeries);

            //Empolyee[] empolyees = new Empolyee[]
            //{
            //    new Empolyee { Id = 1, Name = "Sayed" , Salary = 3000 },
            //    new Empolyee { Id = 1, Name = "Omar" , Salary = 132000 },
            //    new Empolyee { Id = 2, Name = "Mohamed" , Salary = 43000 }

            //};
            //Array.Sort(empolyees);
            //foreach (Empolyee e in empolyees) 
            //{   
            //    Console.WriteLine(e);
            //}
            #endregion

            #region Ex03
            //IFlyable flyable = new Airpane();
            //flyable.Right();

            //IMovable movable = new Airpane();
            //movable.Left();
            #endregion

            #region Shallow copy & Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 5, 7, 9 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = Arr01;
            //Console.WriteLine();

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //// Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 5, 7, 9 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine();

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            #endregion

            #region Built in interface
            //Empolyee Emp1 = new Empolyee() { Id = 1, Name = "Sayed", Salary = 40023 };

            //Empolyee Emp2 = (Empolyee)Emp1.Clone();

            //Empolyee emp3 = new Empolyee(Emp1);

            //Console.WriteLine(Emp1.GetHashCode());
            //Console.WriteLine(Emp2.GetHashCode());
            //Console.WriteLine(emp3.GetHashCode());
            #endregion



        }
    }
}
