using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifires
{
    internal class Son1 : Father
    {
        public string MyName { get; set; }


        protected internal override void Work()
        {
            Console.WriteLine("Iam A SoftWare Eng");
        }

        public new void Habits() 
        {
            Console.WriteLine("I Love Basketball");
        }

        public Son1(string FamilyName , string Address, String FatherName,string MyName) : base(FamilyName,Address,FatherName)
        {
            this.MyName = MyName;
        }

        public Son1(string FamilyName,string MyName) : base(FamilyName)
        {
            this.MyName=MyName;
        }
    }
}
