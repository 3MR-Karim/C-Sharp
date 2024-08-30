using Assingment_03.InterfaceEx03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03.InterfaceEx01
{
    internal interface IMytype
    {
        public void Myfun();

        public int salary { get; set; }


        public void print()
        {
            Console.WriteLine("Hello From Interface");
        }
    }
}
