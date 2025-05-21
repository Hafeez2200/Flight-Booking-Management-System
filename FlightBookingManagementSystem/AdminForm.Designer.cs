namespace FlightBookingManagementSystem
{
    partial class AdminForm
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
        private void InitializeComponent()
        {
            listView1 = new ListView();
            label1 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtrole = new TextBox();
            txtupdateusername = new TextBox();
            txtupdatepassword = new TextBox();
            txtupdaterole = new TextBox();
            addbtn = new Button();
            updatebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            deletebtn = new Button();
            viewflightbtn = new Button();
            viewpaymentbtn = new Button();
            viewuserbtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(14, 87);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(485, 359);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 24);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 1;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(699, 84);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(164, 32);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(699, 141);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(164, 32);
            txtpassword.TabIndex = 3;
            // 
            // txtrole
            // 
            txtrole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtrole.Location = new Point(699, 197);
            txtrole.Margin = new Padding(3, 4, 3, 4);
            txtrole.Name = "txtrole";
            txtrole.Size = new Size(164, 32);
            txtrole.TabIndex = 4;
            // 
            // txtupdateusername
            // 
            txtupdateusername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtupdateusername.Location = new Point(699, 348);
            txtupdateusername.Margin = new Padding(3, 4, 3, 4);
            txtupdateusername.Name = "txtupdateusername";
            txtupdateusername.Size = new Size(164, 32);
            txtupdateusername.TabIndex = 5;
            // 
            // txtupdatepassword
            // 
            txtupdatepassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtupdatepassword.Location = new Point(699, 411);
            txtupdatepassword.Margin = new Padding(3, 4, 3, 4);
            txtupdatepassword.Name = "txtupdatepassword";
            txtupdatepassword.Size = new Size(164, 32);
            txtupdatepassword.TabIndex = 6;
            // 
            // txtupdaterole
            // 
            txtupdaterole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtupdaterole.Location = new Point(699, 473);
            txtupdaterole.Margin = new Padding(3, 4, 3, 4);
            txtupdaterole.Name = "txtupdaterole";
            txtupdaterole.Size = new Size(164, 32);
            txtupdaterole.TabIndex = 7;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ButtonHighlight;
            addbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.Location = new Point(567, 264);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(131, 61);
            addbtn.TabIndex = 8;
            addbtn.Text = "Add User";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = SystemColors.ButtonHighlight;
            updatebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.Location = new Point(567, 548);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(134, 61);
            updatebtn.TabIndex = 9;
            updatebtn.Text = "Update User";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(545, 93);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 10;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(545, 151);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 11;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(545, 207);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 12;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(545, 477);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 15;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(545, 415);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 14;
            label6.Text = "password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(545, 357);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 13;
            label7.Text = "username";
            // 
            // deletebtn
            // 
            deletebtn.BackColor = SystemColors.ButtonHighlight;
            deletebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(14, 511);
            deletebtn.Margin = new Padding(3, 4, 3, 4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(134, 61);
            deletebtn.TabIndex = 16;
            deletebtn.Text = "Delete User";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // viewflightbtn
            // 
            viewflightbtn.BackColor = SystemColors.ButtonHighlight;
            viewflightbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewflightbtn.Location = new Point(173, 511);
            viewflightbtn.Margin = new Padding(3, 4, 3, 4);
            viewflightbtn.Name = "viewflightbtn";
            viewflightbtn.Size = new Size(134, 61);
            viewflightbtn.TabIndex = 17;
            viewflightbtn.Text = "View Flights";
            viewflightbtn.UseVisualStyleBackColor = false;
            viewflightbtn.Click += viewflightbtn_Click;
            // 
            // viewpaymentbtn
            // 
            viewpaymentbtn.BackColor = SystemColors.ButtonHighlight;
            viewpaymentbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewpaymentbtn.Location = new Point(331, 511);
            viewpaymentbtn.Margin = new Padding(3, 4, 3, 4);
            viewpaymentbtn.Name = "viewpaymentbtn";
            viewpaymentbtn.Size = new Size(134, 61);
            viewpaymentbtn.TabIndex = 18;
            viewpaymentbtn.Text = "View Payments";
            viewpaymentbtn.UseVisualStyleBackColor = false;
            viewpaymentbtn.Click += viewpaymentbtn_Click;
            // 
            // viewuserbtn
            // 
            viewuserbtn.BackColor = SystemColors.ButtonHighlight;
            viewuserbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewuserbtn.Location = new Point(173, 620);
            viewuserbtn.Margin = new Padding(3, 4, 3, 4);
            viewuserbtn.Name = "viewuserbtn";
            viewuserbtn.Size = new Size(134, 61);
            viewuserbtn.TabIndex = 19;
            viewuserbtn.Text = "View Users";
            viewuserbtn.UseVisualStyleBackColor = false;
            viewuserbtn.Click += viewuserbtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 697);
            Controls.Add(viewuserbtn);
            Controls.Add(viewpaymentbtn);
            Controls.Add(viewflightbtn);
            Controls.Add(deletebtn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(txtupdaterole);
            Controls.Add(txtupdatepassword);
            Controls.Add(txtupdateusername);
            Controls.Add(txtrole);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "AdminForm";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private ListView listView1;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtrole;
        private TextBox txtupdateusername;
        private TextBox txtupdatepassword;
        private TextBox txtupdaterole;
        private Button addbtn;
        private Button updatebtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button deletebtn;
        private Button viewflightbtn;
        private Button viewpaymentbtn;
        private Button viewuserbtn;
    }
}