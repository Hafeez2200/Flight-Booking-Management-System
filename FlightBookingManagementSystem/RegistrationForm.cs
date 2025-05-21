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
    public partial class RegistrationForm : Form
    {
        public int NewCustomerId { get; private set; } = -1;
        public string FullName { get; private set; } = "";

        string connStr = "server=localhost;user=root;database=flightbookingmanagement;port=3306;";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtfullname.Text.Trim();
            string email = txtemail.Text.Trim();
            string phone = txtphone.Text.Trim();
            string passport = txtpassport.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Name and Email are required.");
                return;
            }

            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = @"INSERT INTO Customers (FullName, Email, Phone, PassportNumber)
                         VALUES (@name, @mail, @phone, @pass); SELECT LAST_INSERT_ID();";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@pass", passport);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                NewCustomerId = Convert.ToInt32(result);
                FullName = fullName;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }

            conn.Close();
        }
    }
}
