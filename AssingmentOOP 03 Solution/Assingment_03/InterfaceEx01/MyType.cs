using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03.InterfaceEx01
{
    internal class MyType : IMytype
    {
        public int salary { get; set; }

        public void Myfun()
        {
            Console.WriteLine("Hello from MyFun");
        }
    }
}
