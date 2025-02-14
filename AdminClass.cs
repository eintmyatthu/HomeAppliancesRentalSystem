using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Home_Appliances_Rental_System;
using MySql.Data.MySqlClient;

namespace Home_Appliances_Rental_System
{
    public class AdminClass
    {
        private string name;
        private string password;

        public string Name { get; set; }
        public string Password { get; set; }

        public AdminClass(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
    
}
