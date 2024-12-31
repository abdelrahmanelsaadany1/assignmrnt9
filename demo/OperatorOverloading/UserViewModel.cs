using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.OperatorOverloading
{
    internal class UserViewModel
    {
       
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public static  explicit operator UserViewModel(User user)
        {
            string[]? Names = user?.FullName.Split(' ');
            return new UserViewModel
            {
                FName = Names?.Length > 0 ? Names[0]:string.Empty,
                LName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email = user.Email,
                Password = user.Password,

            };
        }
    }
}
