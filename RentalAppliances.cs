using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Home_Appliances_Rental_System
{
    public partial class RentalAppliances : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;

        List<Appliances> appliances = new List<Appliances>();
        public RentalAppliances()
        {
            InitializeComponent();
        }

        private void RentalAppliances_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
            con = new MySqlConnection(constring);

            // Load and display appliances
            LoadAppliances();
        }
        private void LoadAppliances()
        {
            con.Open();
            string sql = "select * from tblappliance";
            cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Display appliances in a DataGridView (dgv_customerView)
                dgv_customerView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchType = cmbo_type.Text; // Get the type to search for from a TextBox

            // Clear the DataGridView before populating it with search results
            dgv_customerView.Rows.Clear();

            con.Open();
            string sql = "SELECT * FROM tblappliance WHERE type = @searchType";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@searchType", searchType);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Display the filtered appliances in the DataGridView (dgv_customerView)
                dgv_customerView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            con.Close();
        }

        private void btn_orderByConsumption_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView before populating it with sorted results
            dgv_customerView.Rows.Clear();

            con.Open();
            string sql = "SELECT * FROM tblappliance ORDER BY energy_consumption ASC";
            cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Display the sorted appliances in the DataGridView (dgv_customerView)
                dgv_customerView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            con.Close();

        }

        private void btn_orderByFee_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView before populating it with sorted results
            dgv_customerView.Rows.Clear();

            con.Open();
            string sql = "SELECT *, monthly_fee FROM tblappliance ORDER BY monthly_fee ASC";
            cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Display the sorted appliances in the DataGridView (dgv_customerView)
                dgv_customerView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            con.Close();

        }

        private void btn_addShopping_Click(object sender, EventArgs e)
        {
            // Retrieve selected appliance details from the DataGridView
            string brand = dgv_customerView.SelectedRows[0].Cells[0].Value.ToString();
            string type = dgv_customerView.SelectedRows[0].Cells[1].Value.ToString();
            string model = dgv_customerView.SelectedRows[0].Cells[2].Value.ToString();
            int monthlyFee = Convert.ToInt32(dgv_customerView.SelectedRows[0].Cells[6].Value);

            // Check if the item is already in the cart
            var existingItem = shoppingCart.FirstOrDefault(item => item.Brand == brand);

            if (existingItem != null)
            {
                // If the item is already in the cart, update the quantity
                existingItem.Quantity++;
            }
            else
            {
                // If the item is not in the cart, add it
                shoppingCart.Add(new ShoppingCartItem
                {
                    Brand = brand,
                    Type = type,
                    Model = model,
                    MonthlyFee = monthlyFee,
                    Quantity = 1
                });
            }

            // Refresh the shopping cart display
            RefreshShoppingCartDisplay();


        }
        private void RefreshShoppingCartDisplay()
        {
            // Clear the shopping cart display
            dgv_shoppingCart.Rows.Clear();
           
                foreach (var item in shoppingCart)
                {
                    // Add the shopping cart items to the DataGridView
                    dgv_shoppingCart.Rows.Add(item.Brand, item.Type, item.Model, item.MonthlyFee, item.Quantity, item.Subtotal);
                }

                // Optionally, you can also calculate and display the total price
                CalculateTotalPrice();
                 
           
        }
        //bool result = false;
        private void CalculateTotalPrice()
        {
            int totalPrice = shoppingCart.Sum(item => item.MonthlyFee * item.Quantity);

            // Display the total price

            DialogResult res = MessageBox.Show("Are you sure you want to rent?", "Rent or not?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Total Price: " + totalPrice.ToString("C"));
                MessageBox.Show("Successfully order to rent!");
            }
           
            con.Close();


        }

        public class ShoppingCartItem
        {
            public string Brand { get; set; }
            public string Type { get; set; }
            public string Model { get; set; }
            public int MonthlyFee { get; set; }
            public int Quantity { get; set; }

            public int Subtotal => MonthlyFee * Quantity;
        }

        List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();

        private void dgv_shoppingCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog to confirm the logout action
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the current form
                this.Close();
                this.Hide();

                //After Loging out, go to HomePage
                HomePage homepage = new HomePage();
                homepage.ShowDialog();
            }


        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
        private void RemoveFromCart()
        {
            // Clear the shopping cart display
            dgv_shoppingCart.Rows.Clear();

            foreach (var item in shoppingCart)
            {
                // Add the shopping cart items to the DataGridView
                dgv_shoppingCart.Rows.Add(item.Brand, item.Type, item.Model, item.MonthlyFee, item.Quantity, item.Subtotal);
            }

            // Optionally, you can also calculate and display the total price
            RemovePrice();


        }
        //bool result = false;
        private void RemovePrice()
        {
            int totalPrice = shoppingCart.Sum(item => item.MonthlyFee * item.Quantity);

            // Display the total price

            DialogResult res = MessageBox.Show("Are you sure you want to remove?", "Remove or not?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Total Price: " + totalPrice.ToString("C"));
                MessageBox.Show("Successfully order removing!");
            }

            con.Close();


        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_shoppingCart.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_shoppingCart.SelectedRows[0];
                string brand = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                Console.WriteLine("Selected Brand: " + brand); // Add this line

                ShoppingCartItem itemToRemove = shoppingCart.FirstOrDefault(item => item.Brand == brand);
                if (itemToRemove != null)
                {
                    shoppingCart.Remove(itemToRemove);
                    RemoveFromCart();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the shopping cart.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}