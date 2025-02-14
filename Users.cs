using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Home_Appliances_Rental_System
{
    public class Users
    {
        private string name;
        private string password;
        private string confirmPassword;
        private string phone;
        private string address;
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // Database connection string
        private static readonly string connectionString = "server=localhost;uid=root;pwd=1234;database=rental_appliances";

        public Users()
        {
            Name = name;
            Password = password;
            ConfirmPassword = confirmPassword;
            Phone = phone;
            Address = address;
        }
    }

   
}
