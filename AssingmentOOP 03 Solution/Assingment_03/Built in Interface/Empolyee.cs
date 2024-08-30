using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03.Built_in_Interface
{
    internal class Empolyee : ICloneable
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public double Salary { get; set; }
        public Empolyee(Empolyee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        public Empolyee()
        {
            
        }
        public object Clone()
        {
            return new Empolyee(this);
            //return new Empolyee() { Id = this.Id, Name = this.Name, Salary = this.Salary };
        } 

        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name}, Salary : {Salary} ";
        }
    }
}
