using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Home_Appliances_Rental_System
{
    public partial class AdminLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 3;

        public AdminLogin()
        {
            InitializeComponent();
           
        }
    
    
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txt_adminPassword.UseSystemPasswordChar = true;

        }

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {

            // Toggle the visibility of the password in the password TextBox
            if (chk_password.Checked == true)
            {
                txt_adminPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txt_adminPassword.UseSystemPasswordChar = true;

            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string adminName = txt_adminName.Text;
            string adminPassword = txt_adminPassword.Text;
            string constring = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
            try
            {
                string sql = "SELECT * FROM tbladmin WHERE adminName=@adminName AND adminPassword=@adminPassword";
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@adminName", adminName);
                cmd.Parameters.AddWithValue("@adminPassword", adminPassword);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Check if there's a matching record in the database
                {
                    // The username and password are correct.
                    // To perform further actions here.
                    AdminViewAppliances adminViewAppliances = new AdminViewAppliances();
                    this.Hide();
                    adminViewAppliances.ShowDialog();
                }
                else
                {
                    loginAttempts++;

                    if (loginAttempts >= maxLoginAttempts)
                    {
                        MessageBox.Show("Maximum login attempts reached. Please try again later.");
                        this.Hide();
                        HomePage homepage = new HomePage();
                        homepage.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is wrong! You have " + (maxLoginAttempts - loginAttempts) + " attempt(s) left.");
                    }
                }

                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
        }
    }
}
