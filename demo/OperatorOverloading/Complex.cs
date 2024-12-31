using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        #region binary Operator overloading
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1?.Real??0) + (c2?.Real??0),
                Imaginary = (c1?.Imaginary??0) + (c2?.Imaginary??0)
            };
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
                Imaginary = (c1?.Imaginary ?? 0) - (c2?.Imaginary ?? 0)
            };
        }

        #endregion
        #region unary operator 
       public static Complex operator ++(Complex Number)
        {
            return new Complex
            {
                Real = (Number?.Real + 1??0),
                Imaginary = (Number?.Imaginary + 1??0)
            };
        }
        public static Complex operator --(Complex Number)
        {
            return new Complex
            {
                Real = (Number?.Real - 1 ?? 0),
                Imaginary = (Number?.Imaginary - 1 ?? 0)
            };
        }
        #endregion
        #region Operational operator 
        public static bool operator >(Complex c1, Complex c2)
        {
          if (c1?.Real > c2.Real && c1.Imaginary > c2.Imaginary)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            if (c1?.Real < c2.Real && c1.Imaginary < c2.Imaginary)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region CastingOperator
        public static  explicit operator int(Complex c1)
        {
            return c1?.Real ?? 0;
                
        }
        public static implicit operator string(Complex c1)
        {
            
            return $" imaginary : {c1.Imaginary}i";   

        }
        #endregion
        public override string ToString()
        {
            return $"real number :{Real} imaginary : {Imaginary}i";
        }
    }
}
