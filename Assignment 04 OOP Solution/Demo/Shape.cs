using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Abstract Class : Partial Implemented Class [Not fully Implemented Class]
    // Concret Class : Complete Implmeted Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : Like Virtual Method Without Implementation
        public abstract double GetArea();
        // you should make this mehod abstract method
        // Make The Childern who inherits from the shape Implement this methods


        // Abstract Property : Like Virtual Property Without Implementation
        public abstract double Premeter { get; }

        public void Print()
        {
            Console.WriteLine("Iam Shape");
        }
        
    }

    class Rectangle : Shape /*: Inherit And Implement*/
    {
        public override double Premeter 
        { 
            get 
            {
                return (Dim01 + Dim02)*2;
            } 
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Square : Shape
    {
        public override double Premeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
