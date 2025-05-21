namespace FlightBookingManagementSystem
{
    partial class CustomerForm
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
            btnbookflight = new Button();
            btnsearchflight = new Button();
            txtOrigin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDestination = new TextBox();
            btnviewbookings = new Button();
            btnmakepayment = new Button();
            label3 = new Label();
            comboBoxPaymentmethod = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 475);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // btnViewFlights
            // 
            btnViewFlights.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewFlights.Location = new Point(845, 119);
            btnViewFlights.Name = "btnViewFlights";
            btnViewFlights.Size = new Size(166, 78);
            btnViewFlights.TabIndex = 1;
            btnViewFlights.Text = "View Flights";
            btnViewFlights.UseVisualStyleBackColor = true;
            btnViewFlights.Click += btnViewFlights_Click;
            // 
            // btnbookflight
            // 
            btnbookflight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnbookflight.Location = new Point(126, 600);
            btnbookflight.Name = "btnbookflight";
            btnbookflight.Size = new Size(166, 78);
            btnbookflight.TabIndex = 2;
            btnbookflight.Text = "Book Flight";
            btnbookflight.UseVisualStyleBackColor = true;
            btnbookflight.Click += btnbookflight_Click;
            // 
            // btnsearchflight
            // 
            btnsearchflight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchflight.Location = new Point(859, 393);
            btnsearchflight.Name = "btnsearchflight";
            btnsearchflight.Size = new Size(166, 78);
            btnsearchflight.TabIndex = 3;
            btnsearchflight.Text = "Search Flights";
            btnsearchflight.UseVisualStyleBackColor = true;
            btnsearchflight.Click += btnsearchflight_Click;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(903, 284);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(188, 27);
            txtOrigin.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(796, 283);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 5;
            label1.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(777, 343);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 6;
            label2.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(903, 341);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(188, 27);
            txtDestination.TabIndex = 7;
            // 
            // btnviewbookings
            // 
            btnviewbookings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnviewbookings.Location = new Point(859, 567);
            btnviewbookings.Name = "btnviewbookings";
            btnviewbookings.Size = new Size(166, 78);
            btnviewbookings.TabIndex = 8;
            btnviewbookings.Text = "My Bookings";
            btnviewbookings.UseVisualStyleBackColor = true;
            btnviewbookings.Click += btnviewbookings_Click;
            // 
            // btnmakepayment
            // 
            btnmakepayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmakepayment.Location = new Point(556, 600);
            btnmakepayment.Name = "btnmakepayment";
            btnmakepayment.Size = new Size(166, 78);
            btnmakepayment.TabIndex = 9;
            btnmakepayment.Text = "Make Payment";
            btnmakepayment.UseVisualStyleBackColor = true;
            btnmakepayment.Click += btnmakepayment_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(429, 26);
            label3.Name = "label3";
            label3.Size = new Size(293, 38);
            label3.TabIndex = 10;
            label3.Text = "Customer Dashboard";
            // 
            // comboBoxPaymentmethod
            // 
            comboBoxPaymentmethod.FormattingEnabled = true;
            comboBoxPaymentmethod.Location = new Point(386, 629);
            comboBoxPaymentmethod.Name = "comboBoxPaymentmethod";
            comboBoxPaymentmethod.Size = new Size(151, 28);
            comboBoxPaymentmethod.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(389, 595);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 12;
            label4.Text = "Payment Method";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 702);
            Controls.Add(label4);
            Controls.Add(comboBoxPaymentmethod);
            Controls.Add(label3);
            Controls.Add(btnmakepayment);
            Controls.Add(btnviewbookings);
            Controls.Add(txtDestination);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOrigin);
            Controls.Add(btnsearchflight);
            Controls.Add(btnbookflight);
            Controls.Add(btnViewFlights);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Button btnViewFlights;
        private Button btnbookflight;
        private Button btnsearchflight;
        private TextBox txtOrigin;
        private Label label1;
        private Label label2;
        private TextBox txtDestination;
        private Button btnviewbookings;
        private Button btnmakepayment;
        private Label label3;
        private ComboBox comboBoxPaymentmethod;
        private Label label4;
    }
}