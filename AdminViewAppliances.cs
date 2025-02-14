using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliances_Rental_System
{
    public partial class AdminViewAppliances : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public AdminViewAppliances()
        {
            InitializeComponent();
        }

        private void AdminViewAppliances_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
            con = new MySqlConnection(constring);
            btn_refresh_Click(sender, e);


        }
        public void clearControls()
        {
            txt_brand.Text = "";
            txt_type.Text = "";
            txt_model.Text = "";
            txt_dimension.Text = "";
            txt_colour.Text = "";
            txt_energyConsumption.Text = "";
            txt_monthlyFee.Text = "";
            txt_appliancesId.Text = "";
        }

        //Add new appliances into database
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into tblappliance(brand,type,model,dimensions,colour,energy_consumption,monthly_fee,appliancesId) values ('" + txt_brand.Text + "','" + txt_type.Text + "','" + txt_model.Text + "','" + txt_dimension.Text + "','" + txt_colour.Text + "','" + txt_energyConsumption.Text + "'," + int.Parse(txt_monthlyFee.Text) + ","+ int.Parse(txt_appliancesId.Text) + ");";
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted!");
            con.Close();
            btn_refresh_Click(sender, e);
            clearControls();
        }

        //Update the existing appliances

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update tblappliance set brand=@brand, type = @type, model = @model, dimensions = @dimensions, colour = @colour, energy_consumption = @energy_consumption, monthly_fee = @monthly_fee where appliancesId = @appliancesId";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
            cmd.Parameters.AddWithValue("@type", txt_type.Text);
            cmd.Parameters.AddWithValue("@model", txt_model.Text);
            cmd.Parameters.AddWithValue("@dimensions", txt_dimension.Text);
            cmd.Parameters.AddWithValue("@colour", txt_colour.Text);
            cmd.Parameters.AddWithValue("@energy_consumption", txt_energyConsumption.Text);
            cmd.Parameters.AddWithValue("@monthly_fee", txt_monthlyFee.Text);  
            cmd.Parameters.AddWithValue("@appliancesId", txt_appliancesId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            btn_refresh_Click(sender, e);
            MessageBox.Show("Update data is successfully!");

        }
        int appliancesId;

        //Delete the damage appliances from database

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "delete from tblappliance where appliancesId = @appliancesId";
            MySqlCommand cmd = new MySqlCommand(@sql, con);
            cmd.Parameters.AddWithValue("@appliancesId", appliancesId);
            DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Delete or not?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted!");
            }
            con.Close();
            btn_refresh_Click(sender, e);
        }

        //Refresh the data after adding, updating or deleting
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_table.Rows.Clear();
            con.Open();
            string sql = "select * from tblappliance";
            cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_table.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

            }
            con.Close();

        }

        // show the data in data grid view from the database
        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != null)
            {
                con.Open();

                txt_brand.Text = dgv_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_type.Text = dgv_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_model.Text = dgv_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_dimension.Text = dgv_table.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_colour.Text = dgv_table.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_energyConsumption.Text = dgv_table.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_monthlyFee.Text = dgv_table.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_appliancesId.Text = dgv_table.Rows[e.RowIndex].Cells[7].Value.ToString();

                string sql = "select appliancesId from tblappliance where brand=@brand and type = @type and model = @model and dimensions = @dimensions and colour = @colour and energy_consumption = @energy_consumption and monthly_fee = @monthly_fee";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                cmd.Parameters.AddWithValue("@type", txt_type.Text);
                cmd.Parameters.AddWithValue("@model", txt_model.Text);
                cmd.Parameters.AddWithValue("@dimensions", txt_dimension.Text);
                cmd.Parameters.AddWithValue("@colour", txt_colour.Text);
                cmd.Parameters.AddWithValue("@energy_consumption", txt_energyConsumption.Text);
                cmd.Parameters.AddWithValue("@monthly_fee", txt_monthlyFee.Text);
                cmd.Parameters.AddWithValue("@appliancesId", txt_appliancesId.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appliancesId = int.Parse(reader[0].ToString());
                }
                con.Close();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog to confirm the logout action
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the current form
                

                //After Loging out, go to HomePage
                HomePage homepage = new HomePage();
                this.Hide();
                homepage.ShowDialog();
            }
        }
    }
}
