using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Parent");
        } 
    }
     class Child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }   
        override sealed public void Print()
        {
            Console.WriteLine("Child");
        }
    }
    
   sealed class grandChild : Child
    {
        //override public void Print()
        //{
        //    Console.WriteLine("GrandChild");
        //}

    }

}
