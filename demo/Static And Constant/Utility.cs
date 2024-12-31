using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Static_And_Constant
{
    internal class Utility
    {
        public int X { get; set; }
        public double Y { get; set; }
     
        private const double pi = 3.14;
        public  static double Pi
        {
            get { return pi; }
          
        }


        public Utility(int x, double y)
        {
            this.X = x;
            this.Y = y;
          //  pi=3.14;
        }
       
        //static Utility()
        //{
        //    Pi = 3.14;
        //}   
        public override string ToString()
        {
            return $"x: {X} y: {Y}";
        }
        public static double CmToInch(double cm)
        {
            return cm * 0.393701;
        }
        public static double CalcArea(double r)
        {
            Utility u = new Utility(1, 2);
            return r*r * Pi;
        }
    }
}
