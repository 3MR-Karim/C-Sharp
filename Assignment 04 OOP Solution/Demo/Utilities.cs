using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Helper Class 
    // If Class Is Static Can`t Create object from this class
    // Can`t Have Field because field need object from the class to deal with it
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        public static double pi;

        // Object Member Method
        //public double CmToInch(double cm)
        //{
        //    return cm / 2.54;
        //}

        // PI = 3.14
        public static double PI 
        { 
            get 
            {
                return pi;
            } 
        }
        // Class Member Method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        static Utilities()
        {
            pi = 3.14;
        }
    }
}
