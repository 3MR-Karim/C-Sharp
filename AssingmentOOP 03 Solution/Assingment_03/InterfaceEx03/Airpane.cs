using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03.InterfaceEx03
{
    internal class Airpane : IMovable, IFlyable
    {
        public int Speed { get; set; }
         void IMovable.Forward()
        {
            Console.WriteLine("Forward from Ground");
        }

         void IMovable.Backward()
        {
            Console.WriteLine("Backward from Ground");
        }

         void IMovable.Left()
        {
            Console.WriteLine("left from Ground");
        }

        void IMovable.Right()
        {
            Console.WriteLine("Right from Ground");
        }



        void IFlyable.Forward()
        {
            Console.WriteLine("Forward from Air");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Backward from Air");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("left from Air");
        }

         void IFlyable.Right()
        {
            Console.WriteLine("Right from Air");
        }
    }
}
