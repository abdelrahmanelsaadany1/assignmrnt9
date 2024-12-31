using demo.Abstraction;
using demo.OperatorOverloading;
using demo.Static_And_Constant;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Complex c1 = new Complex { Real = 1, Imaginary = 2 };
            //Complex c2 = new Complex { Real = 2, Imaginary = 4 };
            #region Operator overloading

            //Complex c3 = c1 + c2;
            //Complex c4 = c1 - c2;
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Complex c5 = ++c2;
            //Console.WriteLine(c5);
            //Complex c6 = --c2;
            //Console.WriteLine(c6);
            //if (c1 > c2)
            //{
            //    Console.WriteLine("c1 > c2 a");
            //}
            //else if (c1 < c2)
            //{
            //    Console.WriteLine("c1 < c2 a");
            //}
            //else
            //{
            //    Console.WriteLine("c1 and c2 are  equal");
            //}

            #endregion
            #region CastingOperator
            //Complex c1 = new Complex { Real = 3, Imaginary = 5 };
            //int c2 = (int)c1;
            //Console.WriteLine(c2);
            //string c3 = c1;
            //Console.WriteLine(c3);
            #endregion
            #region Businnes need for casting operator
            //User user = new User();
            //{
            //    user.id = 1;
            //    user.FullName = "John Doe";
            //    user.Email = "abdelrahman@gmail";
            //    user.SecurityStmp = Guid.NewGuid();
            //    user.Password = "123";
            //}
            //UserViewModel userViewModel =(UserViewModel) user;
            //Console.WriteLine(userViewModel.FName);
            //Console.WriteLine(userViewModel.LName);
            //Console.WriteLine(userViewModel.Email);
            //Console.WriteLine(userViewModel.Password);
            #endregion
            #region AbstractClass
            // Rectangle rectangle = new Rectangle() { D1=10,D2=10};
            //decimal Area= rectangle.CalcArea();
            // decimal Perimeter = rectangle.Premiter;
            // Console.WriteLine($"area = {Area}");
            // Console.WriteLine(Perimeter);


            #endregion
            #region Static  
            //Utility utility = new Utility(10, 10.5);
            //Console.WriteLine(utility);
            //double inch = Utility.CmToInch(10);
            //Console.WriteLine(inch);
            //double radius = Utility.CalcArea(10);
            //Console.WriteLine(radius);

            #endregion
            #region Sealed 
            // i implemented the class 
            #endregion
        }
    }
}
