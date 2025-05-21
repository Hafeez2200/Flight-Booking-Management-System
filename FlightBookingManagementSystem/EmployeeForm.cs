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
    public partial class EmployeeForm : Form
    {
        string connStr = "server=localhost;user=root;database=flightbookingmanagement;port=3306;";
        int selectedBookingId = -1;
        int selectedPaymentId = -1;

        public EmployeeForm()
        {
            InitializeComponent();
            
            comboBoxflight.Items.AddRange(new[] { "Pending", "Confirmed", "Cancelled" });
            comboBoxpayment.Items.AddRange(new[] { "Pending", "Paid", "Failed" });
            ViewBookings();
        }

        private void ViewBookings()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("BookingID", 80);
            listView1.Columns.Add("CustomerID", 80);
            listView1.Columns.Add("FlightID", 80);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("BookingDate", 130);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("CALL GetAllBookings();", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                item.SubItems.Add(reader["CustomerID"].ToString());
                item.SubItems.Add(reader["FlightID"].ToString());
                item.SubItems.Add(reader["Status"].ToString());
                item.SubItems.Add(reader["BookingDate"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void ViewPayments()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("PaymentID", 80);
            listView1.Columns.Add("BookingID", 80);
            listView1.Columns.Add("Amount", 100);
            listView1.Columns.Add("PaymentStatus", 100);

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

        private void ViewFlights()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("FlightID", 80);
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

        private void ViewCustomers()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("CustomerID", 100);
            listView1.Columns.Add("FullName", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Phone", 100);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM Customers";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["CustomerID"].ToString());
                item.SubItems.Add(reader["FullName"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(reader["Phone"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem item = listView1.SelectedItems[0];
            string header = listView1.Columns[0].Text;

            selectedBookingId = -1;
            selectedPaymentId = -1;

            if (header == "BookingID" && item.SubItems.Count >= 4)
            {
                selectedBookingId = int.Parse(item.SubItems[0].Text);
                comboBoxflight.Text = item.SubItems[3].Text;
            }
            else if (header == "PaymentID" && item.SubItems.Count >= 4)
            {
                selectedPaymentId = int.Parse(item.SubItems[0].Text);
                comboBoxpayment.Text = item.SubItems[3].Text;
            }

            
        }

        private void btnUpdatestatus_Click(object sender, EventArgs e)
        {
           

            if (selectedBookingId == -1 || string.IsNullOrWhiteSpace(comboBoxflight.Text)) return;

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("CALL UpdateBookingStatus(@id, @status);", conn);
            cmd.Parameters.AddWithValue("@id", selectedBookingId);
            cmd.Parameters.AddWithValue("@status", comboBoxflight.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ViewBookings();
            MessageBox.Show("Booking status updated successfully!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == -1 || string.IsNullOrWhiteSpace(comboBoxpayment.Text)) return;

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "UPDATE Payments SET PaymentStatus = @status WHERE PaymentID = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", comboBoxpayment.Text);
            cmd.Parameters.AddWithValue("@id", selectedPaymentId);
            cmd.ExecuteNonQuery();
            conn.Close();
            ViewPayments();
            MessageBox.Show("Payment status updated successfully!");

        }


        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            ViewFlights();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookings();
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            ViewPayments();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers();
        }

       








    }
}

