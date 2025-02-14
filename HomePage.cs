using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliances_Rental_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            this.Hide();
            userRegister.ShowDialog();
            
        }

        private void btn_user_login_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
            this.Hide();
            userlogin.ShowDialog();
            
        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            this.Hide();
            adminlogin.ShowDialog();
           
        }
    }
}
