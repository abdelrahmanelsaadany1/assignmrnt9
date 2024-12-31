using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Abstraction
{
    internal class Rectangle : Shape
    {
        public override decimal Premiter 
        {



            get { return (D1 + D2) * 2; }


        }

        public override decimal CalcArea()
        {
            return D1 * D2;   
        }
    }
}
