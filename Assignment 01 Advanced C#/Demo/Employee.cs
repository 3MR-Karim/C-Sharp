using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     struct Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        public Employee(int id , string name , int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }


        public override string ToString()
        {
            return $"{Id},{Name},{Salary}";
        }

        public static bool operator == (Employee left , Employee right)
        {
            return left.Equals(right) ;
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return left.Equals(right);
        }


        public override bool Equals(object? obj)
        {

            Employee passedemp = (Employee) obj; // UnSafe casting

            return (this.Salary == passedemp.Salary) && (this.Name == passedemp.Name) && (this.Id == passedemp.Id) ;   
        }

        public int CompareTo(object? obj)
        {
            Employee passedemp = (Employee)obj; // UnSafe casting

            return this.Salary.CompareTo(passedemp.Salary);
            //if(this.Salary > passedemp.Salary)
            //    return 1;
            //else if (this.Salary < passedemp.Salary)
            //    return -1;
            //else
            //    return 0 ;
        }
    }
}
