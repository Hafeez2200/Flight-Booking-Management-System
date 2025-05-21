namespace FlightBookingManagementSystem
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            btnViewFlights = new Button();
            btnViewBookings = new Button();
            btnViewPayments = new Button();
            comboBoxflight = new ComboBox();
            label1 = new Label();
            btnUpdatestatus = new Button();
            button1 = new Button();
            label2 = new Label();
            comboBoxpayment = new ComboBox();
            btnViewCustomers = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(37, 112);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(615, 444);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // btnViewFlights
            // 
            btnViewFlights.BackColor = SystemColors.ButtonHighlight;
            btnViewFlights.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewFlights.Location = new Point(37, 626);
            btnViewFlights.Margin = new Padding(3, 4, 3, 4);
            btnViewFlights.Name = "btnViewFlights";
            btnViewFlights.Size = new Size(145, 75);
            btnViewFlights.TabIndex = 1;
            btnViewFlights.Text = "View Flights";
            btnViewFlights.UseVisualStyleBackColor = false;
            btnViewFlights.Click += btnViewFlights_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.BackColor = SystemColors.ButtonHighlight;
            btnViewBookings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewBookings.Location = new Point(265, 626);
            btnViewBookings.Margin = new Padding(3, 4, 3, 4);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(145, 75);
            btnViewBookings.TabIndex = 2;
            btnViewBookings.Text = "View Bookings";
            btnViewBookings.UseVisualStyleBackColor = false;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnViewPayments
            // 
            btnViewPayments.BackColor = SystemColors.ButtonHighlight;
            btnViewPayments.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewPayments.Location = new Point(508, 626);
            btnViewPayments.Margin = new Padding(3, 4, 3, 4);
            btnViewPayments.Name = "btnViewPayments";
            btnViewPayments.Size = new Size(145, 75);
            btnViewPayments.TabIndex = 3;
            btnViewPayments.Text = "View Payments";
            btnViewPayments.UseVisualStyleBackColor = false;
            btnViewPayments.Click += btnViewPayments_Click;
            // 
            // comboBoxflight
            // 
            comboBoxflight.FormattingEnabled = true;
            comboBoxflight.Location = new Point(894, 147);
            comboBoxflight.Margin = new Padding(3, 4, 3, 4);
            comboBoxflight.Name = "comboBoxflight";
            comboBoxflight.Size = new Size(138, 28);
            comboBoxflight.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(698, 155);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 5;
            label1.Text = "Change Status";
            // 
            // btnUpdatestatus
            // 
            btnUpdatestatus.BackColor = SystemColors.ButtonHighlight;
            btnUpdatestatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatestatus.Location = new Point(781, 212);
            btnUpdatestatus.Margin = new Padding(3, 4, 3, 4);
            btnUpdatestatus.Name = "btnUpdatestatus";
            btnUpdatestatus.Size = new Size(141, 59);
            btnUpdatestatus.TabIndex = 6;
            btnUpdatestatus.Text = "Update Status";
            btnUpdatestatus.UseVisualStyleBackColor = false;
            btnUpdatestatus.Click += btnUpdatestatus_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(781, 402);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 59);
            button1.TabIndex = 9;
            button1.Text = "Update Status";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(698, 339);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 8;
            label2.Text = "Change Payment Status";
            // 
            // comboBoxpayment
            // 
            comboBoxpayment.FormattingEnabled = true;
            comboBoxpayment.Location = new Point(894, 338);
            comboBoxpayment.Margin = new Padding(3, 4, 3, 4);
            comboBoxpayment.Name = "comboBoxpayment";
            comboBoxpayment.Size = new Size(138, 28);
            comboBoxpayment.TabIndex = 7;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.BackColor = SystemColors.ButtonHighlight;
            btnViewCustomers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCustomers.Location = new Point(748, 626);
            btnViewCustomers.Margin = new Padding(3, 4, 3, 4);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(152, 75);
            btnViewCustomers.TabIndex = 10;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.UseVisualStyleBackColor = false;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(416, 22);
            label3.Name = "label3";
            label3.Size = new Size(316, 41);
            label3.TabIndex = 11;
            label3.Text = "Employee Dashboard";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 737);
            Controls.Add(label3);
            Controls.Add(btnViewCustomers);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBoxpayment);
            Controls.Add(btnUpdatestatus);
            Controls.Add(label1);
            Controls.Add(comboBoxflight);
            Controls.Add(btnViewPayments);
            Controls.Add(btnViewBookings);
            Controls.Add(btnViewFlights);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Button btnViewFlights;
        private Button btnViewBookings;
        private Button btnViewPayments;
        private ComboBox comboBoxflight;
        private Label label1;
        private Button btnUpdatestatus;
        private Button button1;
        private Label label2;
        private ComboBox comboBoxpayment;
        private Button btnViewCustomers;
        private Label label3;
    }
}