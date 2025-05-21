using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace FlightBookingManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=flightbookingmanagement;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT Role FROM Users WHERE Username=@username AND PasswordHash=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                cmd.Parameters.AddWithValue("@password", passwordtxt.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    
                    MessageBox.Show($"Login successful! Role: {role}");
                    this.Hide();


                    if (role == "Admin")
                    {
                        AdminForm admin = new AdminForm();
                        admin.FormClosed += (s, args) => this.Close(); // close app when admin form closes
                        admin.Show();
                    }
                    else if (role == "Employee")
                    {
                        EmployeeForm emp = new EmployeeForm();
                        emp.FormClosed += (s, args) => this.Close();
                        emp.Show();
                    }
                    else if (role == "Customer")
                    {
                        CustomerForm cust = new CustomerForm();
                        cust.FormClosed += (s, args) => this.Close();
                        cust.Show();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}