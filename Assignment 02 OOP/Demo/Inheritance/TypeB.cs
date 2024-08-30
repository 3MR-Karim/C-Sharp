using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo.Inheritance
{
    internal class TypeB : TypeA 
    {
        public int B { get; set; }

        // Hiding to the inherited behaviour with new one

        // Applying override
        // 1.new
        // 2.override

        // Apply override using "new" keyword
        // Static Binding Methods [Early bind]
        // Compiler will Bind The Function Call Based on the referencetype not object 
        // Compilation Time
        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        // Apply override using "override" keyword
        // function must be not private and virtual method
        //Dynamic binded method [late bind]
        //CLR will Bind The Function Call Based on the Object not Referencetype
        // call the last override function 
        // Runtime 

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B}");
        }

        public TypeB(int A ,int B) : base(A)
        { 
            this.B = B;
        }
    }
}
