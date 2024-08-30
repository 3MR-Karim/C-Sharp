using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03.InterfaceEx03
{
    internal class Car :IMovable
    {
        public int Speed { get; set; }
        public void Forward()
        {
            Console.WriteLine("Forward from ground");
        }

        public void Backward()
        {
            Console.WriteLine("Backward from ground");
        }

        public void Left()
        {
             Console.WriteLine("left from ground");
        }

        public void Right()
        {
            Console.WriteLine("Right from ground");
        }

        
    }
}
