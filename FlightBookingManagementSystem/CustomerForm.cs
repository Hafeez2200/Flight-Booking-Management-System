using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FlightBookingManagementSystem
{
    public partial class CustomerForm : Form
    {
        string connStr = "server=localhost;user=root;database=flightbookingmanagement;port=3306;";
        int customerId = -1;
        int selectedFlightId = -1;
        int selectedBookingId = -1;

        public CustomerForm()
        {
            InitializeComponent();
            comboBoxPaymentmethod.Items.AddRange(new[] { "Bank Transfer", "Credit Card", "PayPal" });

        }

        private void btnViewFlights_Click(object sender, EventArgs e)
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
            string query = "SELECT * FROM Flights"; // <-- Show all flights
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

        private void btnsearchflight_Click(object sender, EventArgs e)
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
            string query = "CALL SearchFlights(@origin, @dest)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@origin", txtOrigin.Text);
            cmd.Parameters.AddWithValue("@dest", txtDestination.Text);
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            selectedFlightId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            if (listView1.Columns[0].Text == "BookingID")
                selectedBookingId = selectedFlightId;
        }

        private void btnbookflight_Click(object sender, EventArgs e)
        {
            if (selectedFlightId == -1)
            {
                MessageBox.Show("Select a flight first.");
                return;
            }

            if (customerId == -1)
            {
                var regForm = new RegistrationForm();
                if (regForm.ShowDialog() == DialogResult.OK)
                {
                    customerId = regForm.NewCustomerId;

                }
                else
                {
                    MessageBox.Show("Booking cancelled.");
                    return;
                }
            }

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("CALL BookFlight(@custId, @flightId)", conn);
            cmd.Parameters.AddWithValue("@custId", customerId);
            cmd.Parameters.AddWithValue("@flightId", selectedFlightId);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Booking successful!");
            LoadMyBookings();
        }

        private void btnmakepayment_Click(object sender, EventArgs e)
        {
            if (selectedBookingId == -1)
            {
                MessageBox.Show("Select a booking to pay.");
                return;
            }

            if (comboBoxPaymentmethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string method = comboBoxPaymentmethod.SelectedItem.ToString();

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO Payments (BookingID, Amount, PaymentDate, PaymentStatus, PaymentMethod) " +
                           "VALUES (@bid, 300, NOW(), 'Paid', @method)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@bid", selectedBookingId);
            cmd.Parameters.AddWithValue("@method", method);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Payment successful using " + method + "!");
        }

        private void btnviewbookings_Click(object sender, EventArgs e)
        {
            LoadMyBookings();
        }

        private void LoadMyBookings()
        {
            if (customerId == -1) return;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("BookingID", 80);
            listView1.Columns.Add("FlightID", 80);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("BookingDate", 130);

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "SELECT BookingID, FlightID, Status, BookingDate FROM Bookings WHERE CustomerID = @custId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@custId", customerId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                item.SubItems.Add(reader["FlightID"].ToString());
                item.SubItems.Add(reader["Status"].ToString());
                item.SubItems.Add(reader["BookingDate"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

       
    }
}
