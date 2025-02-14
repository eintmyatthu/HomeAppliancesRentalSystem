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

namespace Home_Appliances_Rental_System
{
    public partial class UserLogin : Form
    {
       
        public UserLogin()
        {
            InitializeComponent();
        }
        private int failedLoginAttempts = 0;
        private const int maxLoginAttempts = 3;

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;


        }

        private async void btn_submit_ClickAsync(object sender, EventArgs e)
        {

            string name = txt_name.Text;
            string password = txt_password.Text;
            string sql = "select * from tblusers where userName=@username and password = @password;";

            string constring = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", name);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // Check if there's a matching record in the database
            {
                // The username and password are correct.
                // To perform further actions here.
                RentalAppliances rentalAppliances = new RentalAppliances();
                this.Hide();
                rentalAppliances.ShowDialog();
            }
            else
            {
                failedLoginAttempts++;
                if (failedLoginAttempts >= maxLoginAttempts)
                {
                    MessageBox.Show("You have reached the maximum allowed login attempts.");
                    this.Hide();
                    HomePage homepage = new HomePage();
                    homepage.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Login failed. Attempts left: {maxLoginAttempts - failedLoginAttempts}");
                }
            }

            con.Close();

        }

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the visibility of the password in the password TextBox
            if (chk_password.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;

            }
            else
            {
                txt_password.UseSystemPasswordChar = true;

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
