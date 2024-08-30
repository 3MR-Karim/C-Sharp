using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Generic class
    internal class Helper<T> where T : IComparable<T>
        // T must be class or struct Impelmenting the Built-in interface - > IComparable
    {

         
        public static void BubbleSort(T[] Arr)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                        {
                            Swap(ref Arr[j], ref Arr[j+1]);   
                        }

                    }
                }
            }
          

        }
        public static int SearchArray(T[] Arr , T value)
        {
            if(Arr is not null)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    if (value.Equals(Arr[i]))

                        return i;
                }
            }
            return -1;

        }


        // Generic Method
        public static void Swap<T>(ref T X, ref T Y)
        {
            //Console.WriteLine("=====Swap=====");
            T temp = X;
            X = Y;
            Y = temp;

        }


        //public static void Swap(ref int X , ref int Y)
        //{
        //    Console.WriteLine("=====Swap=====");
        //    int temp = X;   
        //    X = Y;
        //    Y = temp;

        //}

        //public static void Swap(ref double X, ref double Y)
        //{
        //    Console.WriteLine("=====Swap=====");
        //    double temp = X;
        //    X = Y;
        //    Y = temp;

        //}

        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("=====Swap=====");
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;

        //}
    }
}
