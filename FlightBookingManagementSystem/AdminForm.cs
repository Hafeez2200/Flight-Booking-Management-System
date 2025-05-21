using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FlightBookingManagementSystem
{
    public partial class AdminForm : Form
    {
        string connStr = "server=localhost;user=root;database=flightbookingmanagement;port=3306;";
        int selectedUserId = -1;

        public AdminForm()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("UserID", 60);
            listView1.Columns.Add("Username", 100);
            listView1.Columns.Add("Role", 100);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "CALL ViewAllUsers();";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["UserID"].ToString());
                item.SubItems.Add(reader["Username"].ToString());
                item.SubItems.Add(reader["Role"].ToString());
                listView1.Items.Add(item);
            }

            conn.Close();
        }


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = listView1.SelectedItems[0];
            selectedUserId = int.Parse(selectedItem.SubItems[0].Text);
            txtupdateusername.Text = selectedItem.SubItems[1].Text;
            txtupdaterole.Text = selectedItem.SubItems[2].Text;
        }







        private void addbtn_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", txtusername.Text);
            cmd.Parameters.AddWithValue("@p", txtpassword.Text);
            cmd.Parameters.AddWithValue("@r", txtrole.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadUsers();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            try
            {
                string query;

                // Check if password is being updated
                if (string.IsNullOrWhiteSpace(txtupdatepassword.Text))
                {
                    query = "UPDATE Users SET Username=@u, Role=@r WHERE UserID=@id";
                }
                else
                {
                    query = "UPDATE Users SET Username=@u, PasswordHash=@p, Role=@r WHERE UserID=@id";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", txtupdateusername.Text);
                cmd.Parameters.AddWithValue("@r", txtupdaterole.Text);
                cmd.Parameters.AddWithValue("@id", selectedUserId);

                if (!string.IsNullOrWhiteSpace(txtupdatepassword.Text))
                    cmd.Parameters.AddWithValue("@p", txtupdatepassword.Text);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("User updated successfully!");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Update failed. No changes made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }

            conn.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = listView1.SelectedItems[0];
            int id = int.Parse(selectedItem.SubItems[0].Text);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string table = "Users";
            if (selectedItem.Text.StartsWith("FlightID")) table = "Flights";
            else if (selectedItem.Text.StartsWith("PaymentID")) table = "Payments";

            string idColumn = table switch
            {
                "Users" => "UserID",
                "Flights" => "FlightID",
                "Payments" => "PaymentID",
                _ => "UserID"
            };

            string query = $"DELETE FROM {table} WHERE {idColumn} = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadUsers();
        }

        private void viewflightbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("FlightID", 70);
            listView1.Columns.Add("Origin", 100);
            listView1.Columns.Add("Destination", 100);
            listView1.Columns.Add("Departure", 130);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM Flights";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["FlightID"].ToString());
                item.SubItems.Add(reader["Origin"].ToString());
                item.SubItems.Add(reader["Destination"].ToString());
                item.SubItems.Add(reader["DepartureTime"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void viewpaymentbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("PaymentID", 80);
            listView1.Columns.Add("BookingID", 80);
            listView1.Columns.Add("Amount", 80);
            listView1.Columns.Add("Status", 100);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM Payments";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["PaymentID"].ToString());
                item.SubItems.Add(reader["BookingID"].ToString());
                item.SubItems.Add(reader["Amount"].ToString());
                item.SubItems.Add(reader["PaymentStatus"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void viewuserbtn_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        
    }
}
