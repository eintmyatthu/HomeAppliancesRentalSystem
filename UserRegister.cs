using System;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace Home_Appliances_Rental_System
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }


    private void UserRegister_Load(object sender, EventArgs e)
    {
              txt_password.UseSystemPasswordChar = true;
              txt_conf_password.UseSystemPasswordChar = true;
               
    }
        Users user = new Users();
        private void btn_submit_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
                try
                {
                    connection.Open();
                    
                    string name = txt_name.Text;
                    string password = txt_password.Text;
                    string confirmPassword = txt_conf_password.Text;
                    string phone = txt_phone.Text;
                    string address = txt_address.Text;

                user.Name = name;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Phone = phone;
                user.Address = address;
                // Check if username is empty or contains invalid characters
                if (string.IsNullOrWhiteSpace(name) || !IsAlphaNumeric(name))
                {
                    MessageBox.Show("Username must contain only letters and numbers and cannot be empty.");
                }
                // Check password complexity
                else if (!HasComplexPassword(password))
                {
                    MessageBox.Show("Password must have at least one uppercase and one lowercase letter and be between 8 and 16 characters.");
                }
                else if (password != confirmPassword)
                {
                    MessageBox.Show("Password and confirm password do not match.");
                }
                else if (string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("You must enter your phone number.");
                }
                else if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("You must enter your address.");
                }
                else
                {
                    // Insert user data into the database
                    string insertQuery = "INSERT INTO tblusers (userName, password, phone, address) VALUES (@userName, @password, @phone, @address)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@userName", name);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully!");
                        
                        UserLogin userLogin = new UserLogin();
                        this.Hide();
                        userLogin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
                    }
                }
            }

            catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        private bool HasComplexPassword(string password)
        {
            // Password must have at least one uppercase and one lowercase letter and be between 8 and 16 characters.
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }
        private bool IsAlphaNumeric(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z0-9]*$");
        }

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_password.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_conf_password.UseSystemPasswordChar = false;

            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_conf_password.UseSystemPasswordChar = true;


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









