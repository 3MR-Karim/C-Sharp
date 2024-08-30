using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifires
{
    internal class Father
    {

        protected string FatherName { get; set; } // Accessable in the same class and derived classes[child]
        internal string FamilyName { get; set; } // Accessable at any member in same projects
        private string Address { get; set; } // Accessable in Same Class or struct

       

        protected internal virtual void Work() // compination between protected and internal
        {
            Console.WriteLine("I Work as A Doctor");
        }

        public void Habits() //compination between protected and private
        {
            Console.WriteLine("I Love Football");
        }

        private protected void FavFootballTeem()
        {
            Console.WriteLine("Barcelona");
        }

        public Father(string FamilyName, string Address, string FatherName)
        {
            this.FamilyName = FamilyName;
            this.Address = Address;
            this.FatherName = FatherName;
        }

        public Father(string FamilyName)
        {
            this.FamilyName = FamilyName;
        }
    }
}
